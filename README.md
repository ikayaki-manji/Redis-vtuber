# Redis-Vtuberシステム
## Introduction
HDRPでVtuberつくるためのシステム

Vtuberハッカソン2019の作品の通信部分だけ切り出し

（モデル・アセットは有償のものがあるのでオリジナルのシステムは公開しません）

## RedisReadClient
![RedisRead](https://user-images.githubusercontent.com/56545041/69856615-60387900-12d1-11ea-9f44-51012aeabf9c.png)

パラメータ

- Redis Host 
    - RedisServerのHost．ローカルならlocalhost，他のPCにRedisサーバーたてるならxx.xx.xx.x(サーバーのipアドレス)

- Redis Port
    - RedisServerのPort．デフォルトなら6379

- LeftHand
    - Redisサーバーから値を受け取る左手オブジェクト．(実機ではVIVEの左手コントローラ)

- RightHand
    - Redisサーバーから値を受け取る右手オブジェクト．(実機ではVIVEの右手コントローラ)

- Head
    - Redisサーバーから値を受け取る頭オブジェクト．(実機ではVIVEのHeadSet)

- UserID
    - サーバに登録するユーザID．複数台つなげる時ようなので難しいことは考えずに0でおK

- ResultHash
    - Redisからとってきた内容を表示する（デバッグ用）

## 注意
Redisサーバーに接続できないとリクエスト待ちになってUnityEditorが止まるので注意

RedisClientのContextMenuからConnectCheckを押して接続を確認してください