# DEVELOPMENT_ENV.md

# DreamTownIslandModKit 开发环境文档（持续维护）

> 更新时间：2026-06-26
>
> 本文档记录：
>
> * 开发环境
> * 软件版本
> * 下载地址
> * 如何判断应该下载哪个版本
> * 已踩过的坑
> * 解决方案
>
> **每次环境发生变化时必须更新本文档。**

---

# 一、游戏信息

## 游戏

创造都市岛物语（Dream Town Island）

平台：

```
Steam Windows
```

---

## Unity 信息

Unity Version

```
2021.3.11f1
```

查看方式：

PowerShell

```powershell
wmic datafile where name="完整路径\\KairoGames.exe" get Version
```

例如：

```
2021.3.11.23713
```

---

## IL2CPP 判断

游戏目录存在：

```
GameAssembly.dll
```

说明：

```
Unity IL2CPP
```

而不是 Mono。

---

## 游戏位数（最重要）

不要凭经验判断。

使用 PowerShell：

```powershell
$path = "KairoGames.exe"

$fs = [System.IO.File]::OpenRead($path)
$br = New-Object System.IO.BinaryReader($fs)

$fs.Seek(0x3C,0)>$null
$pe=$br.ReadInt32()

$fs.Seek($pe+4,0)>$null

$machine=$br.ReadUInt16()

switch($machine){
0x014c{"x86 / 32-bit"}
0x8664{"x64 / 64-bit"}
default{"Unknown"}
}
```

当前结果：

```
x86 / 32-bit
```

因此：

必须下载：

```
BepInEx Unity IL2CPP x86
```

而不是 x64。

---

# 二、开发工具

## VS Code

推荐最新版

下载：

https://code.visualstudio.com/

---

推荐插件

* C#
* C# Dev Kit
* Error Lens
* GitLens（可选）

---

## Git

最新版即可。

---

## .NET SDK

当前使用：

```
.NET SDK 8
```

注意：

不是 Runtime。

查看：

```powershell
dotnet --list-sdks
```

应该看到：

```
8.x.x
```

查看完整信息：

```powershell
dotnet --info
```

---

踩坑：

错误：

```
dotnet-sdk-8.x-win-x86.exe
```

这是：

```
32 位 SDK
```

不能用于当前开发环境。

正确：

```
dotnet-sdk-8.x-win-x64.exe
```

原因：

开发工具运行在：

```
Windows x64
```

而不是游戏位数。

---

# 三、BepInEx

当前版本：

```
6.0.0-be.760
```

原因：

be.784

生成 interop 时出现：

```
System.MissingMethodException
```

因此退回：

```
be.760
```

正常运行。

---

下载：

Unity IL2CPP

Windows

x86

---

不要下载：

```
Unity Mono
```

不要下载：

```
win-x64
```

---

# 四、UABEA

作用：

查看

* assets
* Texture
* Sprite
* MonoBehaviour

---

# 五、AssetRipper

作用：

导出

* Sprite
* Texture
* Audio
* Mesh

用于逆向资源。

---

# 六、当前开发状态

已完成

✅ 判断 Unity 版本

✅ 判断 IL2CPP

✅ 判断 x86

✅ 安装 BepInEx

✅ 成功生成 interop

下一步：

Hello World Plugin

---

# 七、踩坑记录

## 坑一

误认为：

```
GameAssembly.dll

=

64位
```

错误。

必须实际判断 PE Header。

---

## 坑二

安装：

```
BepInEx x64
```

没有任何 Log。

原因：

游戏实际上：

```
x86
```

---

## 坑三

安装：

```
dotnet Runtime
```

没有 SDK。

表现：

```
dotnet --list-sdks

No SDKs were found.
```

原因：

只安装了 Runtime。

---

## 坑四

安装：

```
dotnet-sdk-x86
```

SDK 无法识别。

正确：

```
dotnet-sdk-x64
```

---

## 坑五

BepInEx be.784

Interop Generation

报：

```
MissingMethodException
```

解决：

使用：

```
be.760
```

---

# 八、以后新增软件

每新增一个软件必须记录：

* 软件用途
* 当前版本
* 下载地址
* 为什么选这个版本
* 如何确认版本是否正确
* 常见错误
* 解决方案
