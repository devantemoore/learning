public static class SortingDemo{
    // bubble
    // very simple to implement and undeerstand; O(n^2); for small datasets

    static List<int> dataset = new List<int>(){ 45, 29, 40, 38, 1, 6, 53, 15, 33};

    public static void BubbleSort(){
        printDataset();

        for(int k = dataset.Count; k > 0; k--){
            for (int i=0; i < k - 1; i++){
                var temp1 = dataset[i];
                var temp2 = dataset[i+1];

                if(temp2 > temp1) continue;

                dataset[i] = temp2;
                dataset[i+1] = temp1;
            }
        }

        printDataset();
    }

    static void printDataset(){
        Console.WriteLine();
        for(int i = 0; i < dataset.Count; i++){
            Console.Write(dataset[i] + "...");
        }
    }
    static void printDataset(List<int> data){
        Console.WriteLine();
        for(int i = 0; i < data.Count; i++){
            Console.Write(data[i] + "...");
        }
    }

    //merge
    // divide & conquer algorithm; uses recursion; O(nlogn); good for large datasets

    public static void MergeSortDemo(){
        printDataset();
        var result = mergeSort(dataset);
        printDataset(result);
    }

    static List<int> mergeSort(List<int> data){
        if ( data.Count == 1) return data;

        var midpoint = data.Count / 2;
        var left = data.GetRange(0, midpoint);
        var right = data.GetRange(midpoint, data.Count - midpoint);

        left = mergeSort(left);
        right = mergeSort(right);
        return merge(left, right);
    }
    static List<int> merge(List<int> left, List<int> right){
        if ( left.Count == 1 && right.Count == 1 ) return left[0] > right[0] ? new List<int>{ right[0], left[0] } : new List<int>{ left[0], right[0]}; // only two elements to swap if necessary

        int leftIndex = 0, rightIndex = 0, resultIndex = 0;
        List<int> result = new();

        while( leftIndex < left.Count && rightIndex < right.Count ){
            if ( left[leftIndex] < right[rightIndex] ){
                result.Add(left[leftIndex]);
                leftIndex++;
            } else {
                result.Add(right[rightIndex]);
                rightIndex++;
            }
        }
        while(leftIndex < left.Count){
            result.Add(left[leftIndex]);
            leftIndex++;
        }
        while(rightIndex < right.Count){
            result.Add(right[rightIndex]);
            rightIndex++;
        }

        return result;
    }
    //quick
    // divide & conquer algo; uses recursion; generally performs better than merge sort; operates in place; worst case is O(n^2) when data is mostly sorted
    // Pivot Position: start with the first element
}