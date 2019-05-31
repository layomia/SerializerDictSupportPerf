``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT


```
|                                Method |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
|                       DeserializeDict |   948.3 ns |  5.016 ns |  4.447 ns | 0.7010 |     - |     - |   2.87 KB |
|                      DeserializeIDict |   959.0 ns |  6.703 ns |  5.942 ns | 0.7000 |     - |     - |   2.87 KB |
|              DeserializeIReadOnlyDict | 1,010.8 ns |  2.997 ns |  2.804 ns | 0.7172 |     - |     - |   2.94 KB |
|                SerializeDict_ToString |   593.5 ns |  1.524 ns |  1.351 ns | 0.3443 |     - |     - |   1.41 KB |
|               SerializeIDict_ToString |   607.2 ns |  2.617 ns |  2.448 ns | 0.3443 |     - |     - |   1.41 KB |
|       SerializeIReadOnlyDict_ToString |   598.5 ns |  2.760 ns |  2.581 ns | 0.3443 |     - |     - |   1.41 KB |
|              DeserializeImmutableDict | 1,426.5 ns |  6.333 ns |  5.924 ns | 0.7629 |     - |     - |   3.12 KB |
|             DeserializeIImmutableDict | 1,839.7 ns | 17.861 ns | 14.915 ns | 0.8793 |     - |     - |   3.59 KB |
|        DeserializeImmutableSortedDict | 1,726.2 ns |  7.363 ns |  6.527 ns | 0.8793 |     - |     - |   3.59 KB |
|       SerializeImmutableDict_ToString | 1,196.9 ns |  6.363 ns |  5.640 ns | 0.3967 |     - |     - |   1.63 KB |
|      SerializeIImmutableDict_ToString | 1,192.0 ns |  3.545 ns |  3.316 ns | 0.3967 |     - |     - |   1.63 KB |
| SerializeImmutableSortedDict_ToString |   948.9 ns |  4.334 ns |  3.842 ns | 0.3748 |     - |     - |   1.53 KB |
