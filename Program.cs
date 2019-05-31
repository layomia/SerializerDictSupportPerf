using System.Text.Json;
using System.Collections.Generic;
using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;

namespace SerializerDictSupport
{
    [JsonExporterAttribute.Full]
    [MemoryDiagnoser]
    public class DictionaryPerf
    {
        private const string _jsonString = @"{""Hello"":""World"",""Hello2"":""World2""}";

        private Dictionary<string, string> _dict = new Dictionary<string, string>() { { "Hello", "World" }, { "Hello2", "World2" } };
        private static IDictionary<string, string> _iDict = new Dictionary<string, string>() { { "Hello", "World" }, { "Hello2", "World2" } };
        private IReadOnlyDictionary<string, string> _iReadOnlyDict = new Dictionary<string, string>() { { "Hello", "World" }, { "Hello2", "World2" } };

        [Benchmark]
        public Dictionary<string, string> DeserializeDict()
        {
            return System.Text.Json.Serialization.JsonSerializer.Parse<Dictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public IDictionary<string, string> DeserializeIDict()
        {
            return System.Text.Json.Serialization.JsonSerializer.Parse<IDictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public IReadOnlyDictionary<string, string> DeserializeIReadOnlyDict()
        {
            return System.Text.Json.Serialization.JsonSerializer.Parse<IReadOnlyDictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public byte[] SerializeDict_ToUtf8Bytes()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToUtf8Bytes(_dict);
        }

        [Benchmark]
        public byte[] SerializeIDict_ToUtf8Bytes()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToUtf8Bytes(_iDict);
        }

        [Benchmark]
        public byte[] SerializeIReadOnlyDict_ToUtf8Bytes()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToUtf8Bytes(_iReadOnlyDict);
        }

        [Benchmark]
        public string SerializeDict_ToString()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToString(_dict);
        }

        [Benchmark]
        public string SerializeIDict_ToString()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToString(_iDict);
        }

        [Benchmark]
        public string SerializeIReadOnlyDict_ToString()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToString(_iReadOnlyDict);
        }
    }

    [JsonExporterAttribute.Full]
    [MemoryDiagnoser]
    public class ImmutableDictionaryPerf
    {
        private const string _jsonString = @"{""Hello"":""World"",""Hello2"":""World2""}";

        private static ImmutableDictionary<string, string> _immutableDict;
        private static IImmutableDictionary<string, string> _iimmutableDict;
        private static ImmutableSortedDictionary<string, string> _immutableSortedDict;

        [GlobalSetup]
        public void Setup()
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>() { { "Hello", "World" }, { "Hello2", "World2" } };

            _immutableDict = ImmutableDictionary.CreateRange(_dict);
            _iimmutableDict = ImmutableDictionary.CreateRange(_dict);
            _immutableSortedDict = ImmutableSortedDictionary.CreateRange(_dict);
        }

        [Benchmark]
        public ImmutableDictionary<string, string> DeserializeImmutableDict()
        {
            return System.Text.Json.Serialization.JsonSerializer.Parse<ImmutableDictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public IImmutableDictionary<string, string> DeserializeIImmutableDict()
        {
            return System.Text.Json.Serialization.JsonSerializer.Parse<IImmutableDictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public ImmutableSortedDictionary<string, string> DeserializeImmutableSortedDict()
        {
            return System.Text.Json.Serialization.JsonSerializer.Parse<ImmutableSortedDictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public byte[] SerializeImmutableDict_ToBytes()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToUtf8Bytes(_immutableDict);
        }

        [Benchmark]
        public byte[] SerializeIImmutableDict_ToBytes()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToUtf8Bytes(_iimmutableDict);
        }

        [Benchmark]
        public byte[] SerializeImmutableSortedDict_ToBytes()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToUtf8Bytes(_immutableSortedDict);
        }

        [Benchmark]
        public string SerializeImmutableDict_ToString()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToString(_immutableDict);
        }

        [Benchmark]
        public string SerializeIImmutableDict_ToString()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToString(_iimmutableDict);
        }

        [Benchmark]
        public string SerializeImmutableSortedDict_ToString()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToString(_immutableSortedDict);
        }
    }

    [JsonExporterAttribute.Full]
    [MemoryDiagnoser]
    public class JsonDotNet_DictionaryPerf
    {
        private const string _jsonString = @"{""Hello"":""World"",""Hello2"":""World2""}";

        private Dictionary<string, string> _dict = new Dictionary<string, string>() { { "Hello", "World" }, { "Hello2", "World2" } };
        private static IDictionary<string, string> _iDict = new Dictionary<string, string>() { { "Hello", "World" }, { "Hello2", "World2" } };
        private IReadOnlyDictionary<string, string> _iReadOnlyDict = new Dictionary<string, string>() { { "Hello", "World" }, { "Hello2", "World2" } };

        private static ImmutableDictionary<string, string> _immutableDict;
        private static IImmutableDictionary<string, string> _iimmutableDict;
        private static ImmutableSortedDictionary<string, string> _immutableSortedDict;

        [GlobalSetup]
        public void Setup()
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>() { { "Hello", "World" }, { "Hello2", "World2" } };

            _immutableDict = ImmutableDictionary.CreateRange(_dict);
            _iimmutableDict = ImmutableDictionary.CreateRange(_dict);
            _immutableSortedDict = ImmutableSortedDictionary.CreateRange(_dict);
        }

        [Benchmark]
        public Dictionary<string, string> DeserializeDict()
        {
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public IDictionary<string, string> DeserializeIDict()
        {
            return JsonConvert.DeserializeObject<IDictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public IReadOnlyDictionary<string, string> DeserializeIReadOnlyDict()
        {
            return JsonConvert.DeserializeObject<IReadOnlyDictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public string SerializeDict_ToString()
        {
            return JsonConvert.SerializeObject(_dict);
        }

        [Benchmark]
        public string SerializeIDict_ToString()
        {
            return JsonConvert.SerializeObject(_iDict);
        }

        [Benchmark]
        public string SerializeIReadOnlyDict_ToString()
        {
            return JsonConvert.SerializeObject(_iReadOnlyDict);
        }

        [Benchmark]
        public ImmutableDictionary<string, string> DeserializeImmutableDict()
        {
            return JsonConvert.DeserializeObject<ImmutableDictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public IImmutableDictionary<string, string> DeserializeIImmutableDict()
        {
            return JsonConvert.DeserializeObject<IImmutableDictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public ImmutableSortedDictionary<string, string> DeserializeImmutableSortedDict()
        {
            return JsonConvert.DeserializeObject<ImmutableSortedDictionary<string, string>>(_jsonString);
        }

        [Benchmark]
        public string SerializeImmutableDict_ToString()
        {
            return JsonConvert.SerializeObject(_immutableDict);
        }

        [Benchmark]
        public string SerializeIImmutableDict_ToString()
        {
            return JsonConvert.SerializeObject(_iimmutableDict);
        }

        [Benchmark]
        public string SerializeImmutableSortedDict_ToString()
        {
            return JsonConvert.SerializeObject(_immutableSortedDict);
        }
    }

    public class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}