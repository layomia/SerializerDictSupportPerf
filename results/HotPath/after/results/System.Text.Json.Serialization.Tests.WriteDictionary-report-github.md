``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-ZIDWVA : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                       Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|----------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|                SerializeDict | 2.951 us | 0.0774 us | 0.0828 us | 2.915 us | 2.827 us | 3.137 us |      0.0909 |           - |           - |               400 B |
|               SerializeIDict | 2.874 us | 0.0381 us | 0.0356 us | 2.859 us | 2.824 us | 2.957 us |      0.0908 |           - |           - |               400 B |
|       SerializeIReadOnlyDict | 3.197 us | 0.2533 us | 0.2711 us | 3.075 us | 2.955 us | 3.915 us |      0.0954 |           - |           - |               400 B |
|       SerializeImmutableDict | 3.759 us | 0.0737 us | 0.0724 us | 3.759 us | 3.650 us | 3.889 us |      0.1763 |           - |           - |               752 B |
|      SerializeIImmutableDict | 3.822 us | 0.0501 us | 0.0468 us | 3.834 us | 3.762 us | 3.899 us |      0.1626 |           - |           - |               752 B |
| SerializeImmutableSortedDict | 3.531 us | 0.0702 us | 0.0751 us | 3.512 us | 3.424 us | 3.696 us |      0.1429 |           - |           - |               656 B |
