class Deque {

    public class Node{
        public int value;
        public Node prev;
        public Node next;

        public Node(int value, Node prev = null, Node next = null){
            this.value = value;
            this.prev = prev;
            this.next = next;
        }
    }

    private Node _head = null;
    private Node _tail = null;

    public Deque() {
    }

    public bool isEmpty() {
        return _head == null;
    }

    public void append(int value) {
        var newNode = new Node(value);

        if (isEmpty()) {
            _head = newNode;
            _tail = newNode;
        } else {
            newNode.prev = _tail;
            _tail.next = newNode;
            _tail = newNode;
        }
    }

    public void appendleft(int value) {
        var newNode = new Node(value);
        if (isEmpty()) {
            _head = newNode;
            _tail = newNode;
        } else {
            newNode.next = _head;
            _head.prev = newNode;
            _head = newNode;
        }
    }

    public int pop() {
        if (isEmpty()){
            return -1;
        }

        var value = _tail.value;

        if (_head == _tail) {
            _head = null;
            _tail = null;
        } else {
            _tail = _tail.prev;
            _tail.next = null;
        }

        return value;
    }

    public int popleft() {
        if (isEmpty()){
            return -1;
        }

        var value = _head.value;

        if (_head == _tail) {
            _head = null;
            _tail = null;
        } else {
            _head = _head.next;
            _head.prev = null;
        }

        return value;
    }
}