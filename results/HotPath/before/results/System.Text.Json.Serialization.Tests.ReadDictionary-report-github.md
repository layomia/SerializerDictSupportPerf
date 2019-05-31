``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-CTTNXB : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                         Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|                DeserializeDict | 2.393 us | 0.0159 us | 0.0149 us | 2.393 us | 2.354 us | 2.415 us |      0.0942 |           - |           - |               416 B |
|               DeserializeIDict | 2.589 us | 0.0972 us | 0.1040 us | 2.571 us | 2.400 us | 2.732 us |      0.0890 |           - |           - |               416 B |
|       DeserializeIReadOnlyDict | 2.510 us | 0.0980 us | 0.1006 us | 2.473 us | 2.406 us | 2.816 us |      0.0960 |           - |           - |               416 B |
|       DeserializeImmutableDict |       NA |        NA |        NA |       NA |       NA |       NA |           - |           - |           - |                   - |
|      DeserializeIImmutableDict |       NA |        NA |        NA |       NA |       NA |       NA |           - |           - |           - |                   - |
| DeserializeImmutableSortedDict |       NA |        NA |        NA |       NA |       NA |       NA |           - |           - |           - |                   - |

Benchmarks with issues:
  ReadDictionary.DeserializeImmutableDict: Job-CTTNXB(Runtime=Core, Toolchain=CoreRun, IterationTime=250.0000 ms, MaxIterationCount=20, MinIterationCount=15, WarmupCount=1)
  ReadDictionary.DeserializeIImmutableDict: Job-CTTNXB(Runtime=Core, Toolchain=CoreRun, IterationTime=250.0000 ms, MaxIterationCount=20, MinIterationCount=15, WarmupCount=1)
  ReadDictionary.DeserializeImmutableSortedDict: Job-CTTNXB(Runtime=Core, Toolchain=CoreRun, IterationTime=250.0000 ms, MaxIterationCount=20, MinIterationCount=15, WarmupCount=1)
