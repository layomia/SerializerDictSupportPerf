``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-CTTNXB : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 3.022 us | 0.0409 us | 0.0383 us | 3.013 us | 2.962 us | 3.106 us |      0.0839 |           - |           - |               360 B |
| SerializeToUtf8Bytes | 2.967 us | 0.0438 us | 0.0409 us | 2.951 us | 2.909 us | 3.047 us |      0.0587 |           - |           - |               280 B |
|    SerializeToStream | 3.229 us | 0.0956 us | 0.1023 us | 3.197 us | 3.119 us | 3.504 us |      0.0714 |           - |           - |               352 B |
