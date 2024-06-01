const fs = require("fs")
const path = require("path")
const { XMLParser, XMLBuilder, XMLValidator } = require("fast-xml-parser");
let changeCase

const replaceClassName = {
    "String": "string",
    "Dictionary": "Godot.Collections.Dictionary",
    "Array": "Godot.Collections.Array",
}

function transformClass(origin) {
    if (!origin) {
        return
    }

    if (replaceClassName[origin]) {
        return replaceClassName[origin]
    }

    return origin
}

function transformCase(origin) {
    return changeCase.capitalCase(origin).replaceAll(" ", "")
}

async function main() {
    changeCase = await import("change-case");


    for (const fpath of fs.readdirSync("./docs")) {
        const fileContent = fs.readFileSync(path.resolve("./docs", fpath))

        const parser = new XMLParser({
            ignoreAttributes: false
        });
        let obj = parser.parse(fileContent);

        if (obj.class["@_inherits"].startsWith("MP") || obj.class["@_name"].startsWith("MP")) {
            const className = obj.class["@_name"]
            const inherits = obj.class["@_inherits"]

            console.log(obj)
            //fs.writeFileSync(path.resolve(apiPath, `${className}.md`), mdContent)

            //console.log(obj)

            let variables = ``
            let methods = ``

            // Variables
            if (obj.class.members) {

                let objMembers = []

                if (obj.class.members.member) {
                    if (Symbol.iterator in Object(obj.class.members.member)) {
                        objMembers = obj.class.members.member
                    } else {
                        objMembers = [obj.class.members.member]
                    }
                }

                for (const m of objMembers) {
                    // Ignore private variables
                    if (m["@_name"].startsWith("_")) {
                        continue
                    }

                    variables += `public ${transformClass(m["@_type"]) ?? "Variant"} ${transformCase(m["@_name"])} {
                        get { return (${transformClass(m["@_type"])})gds.Get("${m["@_name"]}"); }
                        set { gds.Set("${m["@_name"]}", value); }
                      }\n`
                }
            }

            const enums = {}

            if (obj.class.constants) {
                for (const c of obj.class.constants.constant) {
                    if (c["@_enum"]) {
                        if (!enums[c["@_enum"]]) {
                            enums[c["@_enum"]] = []
                        }

                        enums[c["@_enum"]].push(c)

                    }
                }
            }

            for (const [k, v] of Object.entries(enums)) {
                variables += `enum ${transformCase(k)} {\n`
                for (const e of v) {

                    console.log(e)

                    variables += `${transformCase(e["@_name"])},\n`
                }
                variables += `}\n`
            }

            if (obj.class.methods) {

                if (Symbol.iterator in Object(obj.class.methods.method)) {
                    for (const m of obj.class.methods.method) {
                        // Ignore private
                        if (m["@_name"].startsWith("_")) {
                            continue
                        }

                        let paramString = " "
                        let paramCall = " "

                        if (Symbol.iterator in Object(m.param)) {
                            for (const p of m.param) {
                                paramString += `${transformClass(p["@_type"])} ${transformCase(p["@_name"])}, `
                                paramCall += `${transformCase(p["@_name"])}, `
                            }

                            // remove last colon
                            paramString = paramString.slice(0, -2) + " "
                            paramCall = paramCall.slice(0, -2) + " "

                            if (paramCall.trim() != "") {
                                paramCall = "," + paramCall
                            }
                        } else {
                            const p = m.param

                            if (p) {

                                paramString += `${transformClass(p["@_type"])} ${transformCase(p["@_name"])}`
                                paramCall += `, ${transformCase(p["@_name"])}`

                            }
                        }

                        methods += `public ${transformClass(m.return["@_type"]) ?? "void"} ${transformCase(m["@_name"])}(${paramString})
                        {
                            ${m.return["@_type"] != "void" ? `return (${transformClass(m.return["@_type"])})` : ""}gds.Call("${m["@_name"]}"${paramCall});
                        }\n`
                    }
                }
            }

            let csContent = ``

            /*
            if (gdsFiles[className]) {
                csContent += `
                public ${className}()
                {
                    GDScript gdss = GD.Load<GDScript>("res://addons/MultiPlayCore/${gdsFiles[className]}");
                    gds = (GodotObject)gdss.New();
                }`
            }
            */

            csContent += `
            public ${className != "MPBase" ? 'new' : ''} static ${className} GetFromNode(Node node)
            {
                ${className} n = new ${className}();
                n.gds = (GodotObject)node;
                return n;
            }`

            let csFile = `
using Godot;
using System;

public partial class ${className} : ${inherits}
{
    public ${className != "MPBase" ? 'new' : ''} GodotObject gds;

    ${variables}

    ${csContent}

    ${methods}


}        
            `

            fs.writeFileSync(path.resolve(`../mp-addons/multiplaysharp/defs/${className}.cs`), csFile)
        }
    }

}

main()