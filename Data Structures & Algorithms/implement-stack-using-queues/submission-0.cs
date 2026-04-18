public class MyStack {
    Queue<int> main;
    Queue<int> temp;

    public MyStack() {
        main = new Queue<int>();
        temp = new Queue<int>();
    }

    public void Push(int x) {
        main.Enqueue(x);
    }

    public int Pop() {
        while (main.Count() > 1) {
            temp.Enqueue(main.Dequeue());
        }

        var topValue = main.Dequeue();

        while (temp.Count() > 0) {
            main.Enqueue(temp.Dequeue());
        }

        return topValue;
    }

    public int Top() {
        while (main.Count() > 1) {
            temp.Enqueue(main.Dequeue());
        }

        var topValue = main.Dequeue();

        while (temp.Count() > 0) {
            main.Enqueue(temp.Dequeue());
        }

        main.Enqueue(topValue);

        return topValue;
    }

    public bool Empty() {
        return main.Count() <= 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */