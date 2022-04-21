如何使用 protobuf3 https://zhuanlan.zhihu.com/p/26014103
tolua protobuf3 源码项目 https://github.com/starwing/lua-protobuf
Lua 包管理 https://blog.csdn.net/qq_33775402/article/details/110780708
visiual studio 编译lua源文件 https://blog.csdn.net/wujie_03/article/details/72881389

按照 lua包管理的步骤配置好 lua 和 luarocks
为luarocks配置lua环境时注意：
            这一步如果报错，需要在C:/Users/name/AppData/Roaming/ 手动创建一个 luarocks 文件夹
            另外可以根据实际情况分别指定不同的环境值 比如 LUA_INCDIR 等
将F:\mingw64\bin目录下的gcc.exe复制一份，重新命名为mingw32-gcc
执行 luarocks install lua-protobuf

执行完成后会在/AppData/Roaming/luarocks下生成pb.dll和protoc.lua,拷贝到项目中使用


集成：
tolua protobuf3 集成 https://blog.csdn.net/wotingdaonile/article/details/108335255
下载lua-runtime https://github.com/topameng/tolua_runtime
删除里面的pb.c文件
将https://github.com/starwing/lua-protobuf项目中的pb.c和pb.h复制过去
调整pb.c中的代码
按照http://changxianjie.gitee.io/unitypartner/2019/10/01/tolua%E4%B8%AD%E4%BD%BF%E7%94%A8protobuf3%E2%80%94%E9%9B%86%E6%88%90lua-protobuf/
这上面的进行调整
https://blog.csdn.net/linxinfa/article/details/118353526
https://blog.csdn.net/weixin_39754267/article/details/111643495

编译要用到的ndk就用低版本
https://dl.google.com/android/repository/android-ndk-r10e-windows-x86_64.zip