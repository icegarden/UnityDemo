"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var fs_1 = require("fs");
var path_1 = require("path");
var rootFolder = "E:/workspace/unityProjects/Demo/Assets/GameMain/Assets/Spine";
function main() {
    if (!rootFolder) {
        return;
    }
    decodeDir(rootFolder);
}
function decodeDir(dir) {
    var arr = fs_1.readdirSync(dir);
    var len = arr.length;
    for (var i = 0; i < len; i++) {
        var str = arr[i];
        var url = dir + "/" + str;
        var stat = fs_1.statSync(url);
        if (stat.isDirectory()) {
            decodeDir(url);
        }
        else if (stat.isFile()) {
            var ext = path_1.extname(url);
            if (ext == ".atlas") {
                var filestr = fs_1.readFileSync(url, { encoding: "utf-8" });
                fs_1.writeFileSync(url+".txt", filestr, { encoding: "utf-8" });
            }
        }
    }

}
main();
