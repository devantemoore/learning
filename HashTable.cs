public static class HashTableDemo{
    // Key-to-value mappings are unique
    // Hash tables are typically very fast (for large datasets)
    // Hash tables don't order entries in a predictable way

    // create a hash table
    static Dictionary<string, int> hashTable = new Dictionary<string, int>(){
        { "key1", 1 },
        { "key2", 2 },
        { "key3", 3 },
    };

    //static void add

    static void printHashTable(){
        foreach(string key in hashTable.Keys){
            Console.WriteLine("Key: " + key + ", Value: " + hashTable[key]);
        }
    }

    public static void GetDemo(){
        printHashTable();
    }
}