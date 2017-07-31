# Plugin-TTSDanmaku

[![Build status](https://ci.appveyor.com/api/projects/status/o3wb9g7am3h4peny?svg=true)](https://ci.appveyor.com/project/Elepover/plugin-ttsdanmaku)

The TTSDanmaku plugin for bililive_dm (https://github.com/copyliu/bililive_dm)

Description last updated at: 07/31/2017 08:52 (GMT)

有问题或是有建议可以 [在作者的 Blog](https://blog.elepover.com/quoteLeft.html) 通过评论提交。

[在此感谢](https://github.com/Elepover/Plugin-TTSDanmaku/blob/master/THANKS.md)每一位为此插件做出贡献的用户。

安装方法
----

下载并解压缩得到 `TTSDanmaku.dll`

 1. 将 `TTSDanmaku.dll` 复制到 `%USERPROFILE%\Documents\弹幕姬\Plugins`
 2. 打开/重启弹幕姬 -> 插件 -> 右键 **TTSDanmaku** -> 启用插件
 
    btw: %USERPROFILE%\Documents 即 我的文档，上方路径可直接复制到资源管理器路径栏中。

日常使用
----

使用截图:

![使用截图](https://www.danmuji.cn/resource/TTSDanmaku/screenshot.png)

(btw, 我懒，实在不想更新截图了🌝)

首次启动 TTSDanmaku 将会自动释放 NAudio.dll 到插件目录中以正常播放 MP3 文件，请不要删除。
* 如遇到提示 NAudio 丢失之类的错误，请参考页面底部下载。
正确的 NAudio 放置位置:

![正确的文件放置](https://www.danmuji.cn/resource/TTSDanmaku/fileplace.png)

如需执行以下操作：

 - 修改设置
 - 清理缓存

请直接在弹幕姬中右键 TTSDanmaku 插件项，选择 **管理** 即可。

更新日志
----

稳定版本（弹幕姬插件仓库版本）: **v1.0.4.53**

最新版本: [**v1.0.4.53**](https://ttsdanmaku.elepover.com)

```
[i] 各前缀说明:
    [i] = 提示
    [!] = 注意
    [+] = 新增
    [/] = 修改

[!] 部分涉及到设置系统变更的版本更新，
    将会重置配置，请在更新后重新设置。
[i] 楼上的问题将在后期版本中解决。

[i] 新版开发进度:

v1.0.4, build 53 ->
[+] 新增更新检查功能 (按住 Shift 进行 Beta 版更新检查)。
[+] GitHub repo 里新增了 AppVeyor 编译状态。
[+] 修复 .NET 框架自带 TTS 引擎的语速和音量问题。
[+] 修改程序集信息。
[+] 为 AppVeyor 进行了 git repo 的文件修改。
[+] 新增网络设置。
[/] Bug 修复。
[/] 精简弹幕姬官网插件描述。

v1.0.4, build 52 ->
[+] 现可自定义房间连接成功读出内容。
[+] 现可修改下载错误重试次数。
[+] 使冷却功能跟进「读完就删」。
[/] 补上了设置窗口的部分 Tooltip.
[/] 修复了智障设置向导按钮的 Layout.
[/] 改进 TTS 播放过程。
[/] 针对超大弹幕压力进行了测试。
[/] 内存占用，**真的**不会再炸妈了。
[/] 在自定义读出内容为空时将不会读出。
[i] 上方的描述不适用于「自定义连接成功读出内容」

v1.0.4, build 51 ->
[+] 新增读完就删缓存功能（来自用户 [@YUXSTUDIO]）
[/] 改进的设置系统，自动更新配置时不会再次报错。
[/] 修复未启用插件时重置配置报错的问题。

v1.0.4, build 50 ->
[+] 新增设置向导功能（可按住 Shift 选择“管理”来打开设置向导）。
[+] *一定程度上*修复内存爆炸问题。
[+] 新增 TTS 音量设置。
[+] 按住 Ctrl 时选择“管理”将会重置配置文件。

v1.0.3, build 49 ->
[+] 设置窗口秘密更新。
[/] 修复诸多启动 / 退出过程中的问题。

v1.0.3, build 48 ->
[+] 新增 Google 娘语音引擎。
    来源项目地址: https://github.com/rcarubbi/Google.TTS
    魔改 By Elepover.
[/] 修复一个 Layout 问题。
[/] 为状态报告窗口修改了默认按钮。

v1.0.3, build 47 ->
[/] (伪) 加快设置窗口处理 TTS 文件速度。
[/] 部分地修复因下载文件不完整导致的 MP3 播放失败。
[/] 修正部分 Layouts.

v1.0.3, build 46 ->
[/] 解决阻止弹幕姬正常退出的问题。
[/] 解决错误退出的问题。
[i] 我可能要食言了...跟进弹幕姬 API 目前任务艰巨啊...

v1.0.3, build 45 ->
[+] 状态报告，以一定频率汇报系统及直播间状态。
[i] 该功能默认关闭。
[!] 启用状态报告后，请务必在关闭弹幕姬前
    停止插件，否则将会无法正常退出弹幕姬。
[+] 从这个版本开始每播放一次 TTS
    将会自动使时间以秒为单位增加一单位。
[i] 下个版本将跟进最新弹幕姬 API, 外加一系列随 API 更新的附属功能。

v1.0.3, build 44 ->
[/] 修复一个导致管理页面出错的问题。
[/] 完善统计系统。
[+] 为部分控件增加 ToolTips.

v1.0.3, build 43 ->
[+] 按 ESC 可以直接关闭设置窗口。
[+] 允许用户自定义弹幕引擎(+ .NET Framework 自带引擎)
[i] 取决于系统完整性，部分盗版系统上无法正常工作。
[+] 新增常见问题（FAQ）入口点。

v1.0.3, build 41 ->
[+] 根据用户 [三冥九夜] 在留言板的建议，
    新增了 自定义弹幕读出内容 以及 自定义礼物读出内容 的选项。
[+] 毫无卵用: 检测 NAudio 是否存在，防止进一步出错（
[+] 改善整体稳定性。
[+] 插件管理页面终于不是丑到家的宋体了。

[i] 用户 [小小小小小马] 所提出的逐条读出弹幕功能正在开发。

v1.0.2, build 32 ->
[+] 根据代码分析做了一定优化。
    Code Analysis Complete -- 0 error(s), 0 warning(s)
[-] 根据 VS 三千瓦电灯泡去掉了多余的 Imports.
    当前全局 Imports:
    Microsoft.VisualBasic
    System
    System.Collections
    System.Collections.Generic
    System.Data
    System.Diagnostics
    System.Linq
    System.Xml.Linq
[-] 去掉了在插件文件夹内释放的多余的一个 NAudio.
[+] 在 Including 中新增了两个暂时没啥用的轮子 ->
    GetHttpStatusCode ->
        向钦定的 URL 发送钦定的请求，获取返回的状（真）态（他）码（妈）。
    GetIP ->
        通过官方钦定 Elepover's APIs 获取 IP。
    NetworkWatchdog ->
        监测网络连接状态。
[+] 新增统计系统。（喂明明写了一大堆代码才这么一句话真的好吗
[/] 于是我又把调试信息改成了统计数据（捂脸逃

v1.0.2, build 30 ->
[+] 设置窗口中所有选项及按钮均对应新增了 ToolTip.
[+] 自动缓存清理选项现已默认启用。
[/] 更新弹幕姬中所显示插件信息。
[i] NoBlockMsgBox 即将作为一个新的 repo 开发。

v1.0.2, build 27 ->
[+] 新增 TTS 冷却选项。
[+] 使用新线程打开管理窗口，取代弹幕姬主进程。
[/] 改善设置系统。
[/] 解决部分代码阻塞弹幕姬主进程的问题。
[!] 此版本未经系统性调试，如有问题请及时反馈。

v1.0.2, build 25 ->
[+] 提高一个版本号（雾
[+] 在部分代码块新增了大批注释。
[i] TTSDanmaku 即将开源。


v1.0.1, build 24 -> 最后发行版本
[+] 尴尬...忘了写关于部分的链接代码了...我还是升级一个 build 吧。

v1.0.1, build 23
[+] 自动清理缓存功能目前已经工作，默认停用。
[+] 手动清理缓存时添加文件占用警告。
[+] 网络问题导致的 TTS 下载失败，默认重试 5 次。
[+] 新增 关于 TTSDanmaku 选项。
[/] 降低启用时对弹幕姬主线程的阻塞。
[/] 改进调试模式输出。
[/] 修改弹幕姬中所显示版本号格式为 主版本.主版本(2).当前版本.编译次数

v1.0.1, build 21
[+] 修复一个导致弹幕姬崩溃的问题。

v1.0.1, build 19
[/] 重写旧版 TTSDanmaku
```

注意事项
----

- TTSDanmaku 不适合出现**大量弹幕**的场合下使用。或是在 build 27+ 的版本中启用**弹幕冷却**选项。
- 插件涉及到配置文件变动的更新或配置文件出错，请手动删除配置文件。
- 下载稳定性取决于网络。
- 大量弹幕同时出现，可能会导致 TTS 夹杂混乱。
- 自定义 弹幕 / 礼物 读出内容中的变量 **大小写敏感**。
- 根据有的用户反馈，NAudio 有概率释放失败，正在寻找原因，请先在[这里](https://www.danmuji.cn/resource/TTSDanmaku/NAudio.dll)下载。

自定义弹幕 / 礼物读出内容格式
----------------

参见 [TTSDanmaku Wiki](https://github.com/Elepover/Plugin-TTSDanmaku/wiki/%E8%87%AA%E5%AE%9A%E4%B9%89%E5%BC%B9%E5%B9%95---%E7%A4%BC%E7%89%A9%E5%86%85%E5%AE%B9%E5%8F%98%E9%87%8F%E8%AF%B4%E6%98%8E)

历史下载
----

**如果新版 TTSDanmaku 工作异常**，请在此下载旧版。

[TTSDanmaku v1.0.1.24](https://www.danmuji.cn/resource/TTSDanmaku/ver10124/TTSDanmaku.zip)

TTSDanmaku 将在作者的下载服务器实时更新，如需体验新版，请[ >在此< ](https://ttsdanmaku.elepover.com)下载。

关于 NAudio 丢失问题
-------------

如果遇到了这种错误:

```
System.IO.FileNotFoundException: 未能加载文件或程序集“NAudio, Version=1.8.0.0, Culture=neutral, PublicKeyToken=null”或它的某一个依赖项。系统找不到指定的文件。
文件名:“NAudio, Version=1.8.0.0, Culture=neutral, PublicKeyToken=null”
```

请在上方注意事项中下载 NAudio，并与 TTSDanmaku 主插件置于一起，重新启用插件即可。
TTSDanmaku 1.0.3+ 中将部分避免此问题发生。
