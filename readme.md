## 开发工具
unity 2021,vscode,visual studio(建议2017)
## 环境
.net 4.7.1
## 部署ILRuntimeDemo
用 nginx 配置一个web服务器，服务器链接指向至GameVersion文件夹
GameVersion中存放的是版本信息和新的版本文件，游戏启动的时候会进行版本比对
并更新下载新的资源

Demo目录是unity主工程项目，自己新建一个unity工程将Assets复制过去

DemoILRuntime目录中是逻辑热更项目，用visual studio开发

demo目录中的Protofiles存放的是proto文件
通过unity中菜单栏中的Tools/proto2cs可以根据proto文件生成对应的cs文件
cs文件存放在DemoILRuntime\src\ProfobufMessage中

Demo\AssetsBuildOut是打包assetbundle的输出目录
这个目录在Assets/GameMain/AppConfigs/ResourceBuilder.xml中可以配置
ResourceEditor.xml是打包编辑器用的配置
ResourceCollection.xml是打包后生成的配置

每次打包assetbundle都会在Demo\AssetsBuildOut中输出对应版本的文件
BuildReport中对应版本文件夹下有一个buidlog.txt，将这个里面的
[16:43:09.646][INFO] Process updatable version list for 'Windows' complete, updatable version list path is 'E:/workspace/unityProjects/Demo/AssetsBuildOut/Full/0_1_1/Windows/GameFrameworkVersion.82931cb0.dat', length is '12103', hash code is '-2104288080[0x82931CB0]', compressed length is '3265', compressed hash code is '1769351924[0x69762AF4]'.
这行里面的信息复制到GameVersion目录下的windowsversion.txt中
这样便能实现文件的比对并热更

Demo\AssetsBuildOut\package这个文件夹下的资源是单机的资源
如果作为单机游戏发现，将这个文件夹下面的文件得到到StreamingAssets中


将Demo\AssetsBuildOut\full文件夹下的对应版本的文件复制到gameversion下与buildInfo.txt同一个目录即可

StreamingAssets可以留空，也可以不留空
如果发布的时候想带一点基础资源，那么将Demo\AssetsBuildOut\packed这个文件夹下的文件复制到StreamingAssets下
如果留空则会下载gameversion下的所有文件



## 其他
因为对fairygui做了修改，所以生成的代码也有调整
将GenCode_CSharp.lua覆盖掉FairyGUI-Editor\FairyGUI-Editor_Data\StreamingAssets\Scripts下的文件

Gameframework也做了一些修改，自己有需要更改的，可以用visual studio重新生成dll

DemoILRuntime编译生成的dll路径在DemoILRuntime.csproj中配置

## luademo
随便撸
## 拓展阅读
https://www.freesion.com/article/6751165761/
https://blog.csdn.net/hawu_hao/article/details/88645092
https://zhuanlan.zhihu.com/p/260216935