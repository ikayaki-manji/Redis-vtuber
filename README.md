# Redis-Vtuberシステム
## Introduction
HDRPでVtuberつくるためのシステム

Vtuberハッカソン2019の作品の通信部分だけ切り出し

（モデル・アセットは有償のものがあるのでオリジナルのシステムは公開しません）

## RedisWriteClient
![RedisWrite](https://user-images.githubusercontent.com/56545041/69854399-61b37280-12cc-11ea-8664-a5727b37fcad.png)

パラメータ

- Redis Host 
    - RedisServerのHost．ローカルならlocalhost，他のPCにRedisサーバーたてるならxx.xx.xx.x(サーバーのipアドレス)

- Redis Port
    - RedisServerのPort．デフォルトなら6379

- LeftHand
    - Redisサーバーに送る左手オブジェクト．(実機ではVIVEの左手コントローラ)

- RightHand
    - Redisサーバーに送る右手オブジェクト．(実機ではVIVEの右手コントローラ)

- Head
    - Redisサーバーに送る頭オブジェクト．(実機ではVIVEのHeadSet)

- UserID
    - サーバに登録するユーザID．複数台つなげる時ようなので難しいことは考えずに0でおK
