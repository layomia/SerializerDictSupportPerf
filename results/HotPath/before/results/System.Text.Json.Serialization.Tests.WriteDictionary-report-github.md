``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-CTTNXB : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                       Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|----------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|                SerializeDict | 2.817 us | 0.0758 us | 0.0709 us | 2.794 us | 2.745 us | 2.990 us |      0.0884 |           - |           - |               400 B |
|               SerializeIDict | 2.856 us | 0.0577 us | 0.0593 us | 2.847 us | 2.778 us | 2.972 us |      0.0891 |           - |           - |               400 B |
|       SerializeIReadOnlyDict | 2.879 us | 0.0713 us | 0.0667 us | 2.852 us | 2.808 us | 3.014 us |      0.0908 |           - |           - |               400 B |
|       SerializeImmutableDict | 3.416 us | 0.0932 us | 0.0778 us | 3.398 us | 3.327 us | 3.639 us |      0.1342 |           - |           - |               600 B |
|      SerializeIImmutableDict |       NA |        NA |        NA |       NA |       NA |       NA |           - |           - |           - |                   - |
| SerializeImmutableSortedDict | 3.257 us | 0.0783 us | 0.0838 us | 3.239 us | 3.150 us | 3.450 us |      0.1172 |           - |           - |               504 B |

Benchmarks with issues:
  WriteDictionary.SerializeIImmutableDict: Job-CTTNXB(Runtime=Core, Toolchain=CoreRun, IterationTime=250.0000 ms, MaxIterationCount=20, MinIterationCount=15, WarmupCount=1)
