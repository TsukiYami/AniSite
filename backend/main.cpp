#include "headerfiles/main.h"

std::string ReadFile(const std::string& sPath) {
    std::ifstream oFile(sPath, std::ios::binary);
    if (!oFile.is_open()) return "";
    return std::string(
        std::istreambuf_iterator<char>(oFile),
        std::istreambuf_iterator<char>()
    );
}

void SendHttpRequest(const SOCKET oServerSocket) {
    while (true) {
        SOCKET oClientSocket = accept(oServerSocket, nullptr, nullptr);
        if (oClientSocket == INVALID_SOCKET) {
            std::cerr << "Error accepting socket." << std::endl;
            WSACleanup();
            break;
        }
        char cBuffer[4096] = {0};
        recv(oClientSocket, cBuffer, sizeof(cBuffer), 0);
        std::string sRequest(cBuffer);

        std::string sPath = "/";
        if (sRequest.find("GET ") != std::string::npos) {
            int nStart = sRequest.find("GET ") + 4;
            int nEnd   = sRequest.find(" ", nStart);
            sPath = sRequest.substr(nStart, nEnd - nStart);
        }

        std::string sBasePath = "F:\\.coding\\Websites\\anime_website\\AniSite\\frontend\\";
        std::string sFilePath;
        std::string sContentType;

        if (sPath == "/") {
            sFilePath = sBasePath + "main.html";
            sContentType = "text/html; charset=UTF-8";
        } else {
            sFilePath = sBasePath + sPath.substr(1);

            if (sPath.ends_with(".css")) sContentType = "text/css";
            else if (sPath.ends_with(".js")) sContentType = "application/javascript";
            else if (sPath.ends_with(".html")) sContentType = "text/html; charset=UTF-8";
            else sContentType = "application/octet-stream";
        }

        std::string sBody = ReadFile(sFilePath);

        std::string sHeader =
            "HTTP/1.1 200 OK\r\n"
            "Content-Type: " + sContentType + "\r\n"
            "Content-Length: " + std::to_string(sBody.length()) + "\r\n"
            "Connection: close\r\n\r\n";

        send(oClientSocket, sHeader.c_str(), sHeader.length(), 0);
        send(oClientSocket, sBody.c_str(), sBody.length(), 0);

        closesocket(oClientSocket);
    }
}

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

    const int nBindingResult = bind(oServerSocket, reinterpret_cast<sockaddr *>(&oServerAddr), sizeof(oServerAddr));
    if (nBindingResult == SOCKET_ERROR) {
        std::cerr << "Error binding socket: " << nBindingResult << std::endl;
        WSACleanup();
    }

    const int nListenServerSocket = listen(oServerSocket, SOMAXCONN);
    if (nListenServerSocket == INVALID_SOCKET) {
        std::cerr << "Error listening socket: " << nListenServerSocket << std::endl;
        WSACleanup();
    }

    std::cout << "Client successfully connected." << std::endl;

    SendHttpRequest(oServerSocket);

    WSACleanup();
    return 0;
}