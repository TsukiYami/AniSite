#include "headerfiles/main.h"

int main() {
    BackendAniSite oBackendAniSite{};

    SOCKET oServerSocket = socket(AF_INET, SOCK_STREAM, 0);
    if (oServerSocket == INVALID_SOCKET) {
        std::cerr << "Error creating socket." << std::endl;
    }

    sockaddr_in oServerAddr{};
    oServerAddr.sin_family = AF_INET;
    oServerAddr.sin_port = htons(9000);
    inet_pton(AF_INET, "127.0.0.1", &oServerAddr.sin_addr);

    const int nBindingResult = bind(oServerSocket, (sockaddr*)&oServerAddr, sizeof(oServerAddr));
    if (nBindingResult == SOCKET_ERROR) {
        std::cerr << "Error binding socket: " << nBindingResult << std::endl;
        WSACleanup();
    }

    const int nListenServerSocket = listen(oServerSocket, SOMAXCONN);
    if (nListenServerSocket == INVALID_SOCKET) {
        std::cerr << "Error listening socket: " << nListenServerSocket << std::endl;
        WSACleanup();
    }

    SOCKET oClientSocket = accept(oServerSocket, nullptr, nullptr);
    if (oClientSocket == INVALID_SOCKET) {
        std::cerr << "Error accepting socket." << std::endl;
        WSACleanup();
    }

    std::cout << "Client succesfully connected." << std::endl;

    send(oClientSocket, "Hello World!", 12, 0);

    WSACleanup();
    return 0;
}