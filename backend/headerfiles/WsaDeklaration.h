//
// Created by felix on 4/3/2026.
//

#ifndef BACKEND_WSADEKLARATION_H

#include "iostream"
#include "winsock2.h"
#include "ws2tcpip.h"

class BackendAniSite {
public:
    BackendAniSite() {
        const int c_nWsaStartUpResult = WSAStartup(WINSOCK_VERSION, &oWsaData);
        if (c_nWsaStartUpResult != 0) {
            std::cerr << "WsaStartUpResult Error: " << c_nWsaStartUpResult << std::endl;
        }
    }

    ~BackendAniSite() {
        WSACleanup();
    }

private:
    WSADATA oWsaData;
};

#define BACKEND_WSADEKLARATION_H

#endif //BACKEND_WSADEKLARATION_H