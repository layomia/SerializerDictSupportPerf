``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-HWCYFJ : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  

```
|                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |---------:|----------:|----------:|---------:|-------:|------:|------:|----------:|
|              DeserializeImmutableDict | 1.947 us | 0.0700 us | 0.1974 us | 1.876 us | 0.6332 |     - |     - |    2649 B |
|             DeserializeIImmutableDict | 1.949 us | 0.0404 us | 0.1147 us | 1.895 us | 0.6332 |     - |     - |    2649 B |
|        DeserializeImmutableSortedDict | 2.532 us | 0.0504 us | 0.1283 us | 2.527 us | 0.7591 |     - |     - |    3177 B |
|        SerializeImmutableDict_ToBytes | 1.606 us | 0.0081 us | 0.0071 us | 1.606 us | 0.1793 |     - |     - |     752 B |
|       SerializeIImmutableDict_ToBytes | 1.685 us | 0.0338 us | 0.0473 us | 1.677 us | 0.1793 |     - |     - |     752 B |
|  SerializeImmutableSortedDict_ToBytes | 1.501 us | 0.0299 us | 0.0265 us | 1.507 us | 0.1564 |     - |     - |     656 B |
|       SerializeImmutableDict_ToString | 1.721 us | 0.0271 us | 0.0290 us | 1.711 us | 0.1869 |     - |     - |     784 B |
|      SerializeIImmutableDict_ToString | 1.709 us | 0.0234 us | 0.0182 us | 1.707 us | 0.1869 |     - |     - |     784 B |
| SerializeImmutableSortedDict_ToString | 1.357 us | 0.0112 us | 0.0094 us | 1.358 us | 0.1640 |     - |     - |     688 B |
