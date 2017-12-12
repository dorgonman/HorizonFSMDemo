git config --local core.longpaths true
git lfs track "Content/**"
git lfs track "Binaries/**"
git config lfs.dialtimeout 600
git config lfs.tlstimeout 600
git config lfs.activitytimeout 600
git config lfs.keepalive 600
git config --list