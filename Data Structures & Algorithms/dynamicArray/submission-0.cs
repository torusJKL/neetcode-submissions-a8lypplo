public class DynamicArray {
    
    private int[] _arr;
    private int _length;

    public DynamicArray(int capacity) {
        _length = 0;
        _arr = new int[capacity];
    }

    public int Get(int i) {
        return _arr[i];
    }

    public void Set(int i, int n) {
        _arr[i] = n;
    }

    public void PushBack(int n) {
        if (_length == _arr.Length) {
            Resize();
        }
        
        _arr[_length] = n;
        ++_length;
    }

    public int PopBack() {
        --_length;
        return _arr[_length];
    }

    public void Resize() {
        int[] newArr = new int[_arr.Length * 2];

        for (int i = 0; i < _length; ++i){
            newArr[i] = _arr[i];
        }

        _arr = newArr;
    }

    public int GetSize() {
        return _length;
    }

    public int GetCapacity() {
        return _arr.Length;
    }
}
