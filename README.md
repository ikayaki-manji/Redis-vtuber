# Redis-Vtuberシステム
## Introduction
HDRPでVtuberつくるためのシステム

Vtuberハッカソン2019の作品の通信部分だけ切り出し

（モデル・アセットは有償のものがあるのでオリジナルのシステムは公開しません）

## やったこと
VRヘッドセットのレンダリングと映像出力用のレンダリングを分けたい

ので、こういう構成にした

![システム構成](https://user-images.githubusercontent.com/56545041/69852954-f4eaa900-12c8-11ea-8729-695cf1033a6b.png)

結果、いいかんじになった

![こいつを](https://user-images.githubusercontent.com/56545041/69852376-70e3f180-12c7-11ea-8b67-5e496576cf17.png)

![こうしたい](https://user-images.githubusercontent.com/56545041/69852402-80fbd100-12c7-11ea-9f78-29084ac44e6a.png)

## このリポジトリ
なんとなく通信部分だけ切り出したので、いい感じに備忘録として活用

各branchに最低限の説明とかがある

オヌヌメは

redis_server

↓

write_client

↓

read_client

の順番で見ていくといいかも