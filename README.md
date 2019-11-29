# Redis-Vtuberシステム
## Introduction
HDRPでVtuberつくるためのシステム

Vtuberハッカソン2019の作品の通信部分だけ切り出し

（モデル・アセットは有償のものがあるのでオリジナルのシステムは公開しません）

## RedisServer
最低限のところだけ

とりあえずredis-server.exeを起動できればいいです

### WindowsにRedisサーバーを立てる場合

https://github.com/MicrosoftArchive/redis/releases

ここからダウンロードしてredis-server.exeを起動してください

### MacにRedisサーバーを立てる場合

```
$ brew install Redis
```

インストールできたら

```
$ redis-server
```

## 別のPCからRedisサーバーにアクセスする時
Redisサーバーを立てているPCで

(Windowsなら)redis-cli.exe

(Macなら)
```
$ redis-cli
```

で、RedisClientを起動して、下記コマンドを入力

```
CONFIG SET protected-mode no
```