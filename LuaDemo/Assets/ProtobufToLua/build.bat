cd protofiles
for %%i in (*.proto) do (
protoc --plugin=protoc-gen-lua="..\plugin\protoc.bat" %%i --lua_out=..\..\LuaScript\protobuf\
)

pause