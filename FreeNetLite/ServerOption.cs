using System;
using System.Collections.Generic;
using System.Text;

namespace FreeNetLite;

public class ServerOption
{
    public int Port { get; set; } = 32451;
    public int MaxConnectionCount { get; set; } = 1000; //최대 동시 접속자 수
    public int ReceiveBufferSize { get; set; } = 4096; //버퍼의 크기 (Buffer : 클라이언트가 보낸 데이터 정보를 일시적으로 저장
    public int MaxPacketSize { get; set; } = 1024; // 페킷의 최대 크기


          
    public void WriteConsole()
    {
        Console.WriteLine("[ ServerOption ]");
        Console.WriteLine($"Port: {Port}");
        Console.WriteLine($"MaxConnectionCount: {MaxConnectionCount}");
        Console.WriteLine($"ReceiveBufferSize: {ReceiveBufferSize}");
        Console.WriteLine($"MaxPacketSize: {MaxPacketSize}");
    }
}

