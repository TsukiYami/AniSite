cmake_minimum_required(VERSION 4.2)
project(backend)

set(CMAKE_CXX_STANDARD 26)

add_executable(backend main.cpp
        headerfiles/main.h
        headerfiles/WsaDeklaration.h)

target_link_libraries(backend ws2_32)