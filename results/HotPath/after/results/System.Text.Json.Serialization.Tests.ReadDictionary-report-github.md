``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-ZIDWVA : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                         Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|                DeserializeDict | 2.594 us | 0.1815 us | 0.2091 us | 2.488 us | 2.400 us | 3.078 us |      0.0948 |           - |           - |               416 B |
|               DeserializeIDict | 2.480 us | 0.0295 us | 0.0262 us | 2.483 us | 2.428 us | 2.517 us |      0.0896 |           - |           - |               416 B |
|       DeserializeIReadOnlyDict | 2.502 us | 0.0475 us | 0.0421 us | 2.503 us | 2.442 us | 2.577 us |      0.0914 |           - |           - |               416 B |
|       DeserializeImmutableDict | 4.201 us | 0.0843 us | 0.0971 us | 4.187 us | 4.060 us | 4.373 us |      0.2467 |           - |           - |              1072 B |
|      DeserializeIImmutableDict | 4.158 us | 0.0559 us | 0.0523 us | 4.172 us | 4.063 us | 4.252 us |      0.2457 |           - |           - |              1072 B |
| DeserializeImmutableSortedDict | 4.672 us | 0.0634 us | 0.0593 us | 4.686 us | 4.567 us | 4.767 us |      0.3563 |           - |           - |              1568 B |
