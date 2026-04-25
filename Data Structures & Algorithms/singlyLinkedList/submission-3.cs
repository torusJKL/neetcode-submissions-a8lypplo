public class LinkedList {

    public class Node {
        public int val;
        public Node next;

        public Node(int val, Node nextNode = null){
            this.val = val;
            this.next = nextNode;
        }
    }

    private Node _head;
    private Node _tail;

    public LinkedList() {
        _head = new Node(-1); // dummy node so that we have an anchor
        _tail = _head;
    }

    public int Get(int index) {
        if (index < 0){
            return -1;
        }

        var curr = _head.next;
        var i = 0;

        while (i < index && curr != null){
            curr = curr.next;
            ++i;
        }

        if (curr == null){
            return -1;
        }

        return curr.val;
    }

    public void InsertHead(int val) {
        var newNode = new Node(val, _head.next);
        _head.next = newNode;

        // first node insertion edge case
        if (newNode.next == null){
            _tail = newNode;
        }
    }

    public void InsertTail(int val) {
        Node newNode = new Node(val);

        _tail.next = newNode;
        _tail = newNode;
    }

    public bool Remove(int index) {
        if (index < 0){
            return false;
        }

        var curr = _head;
        var i = 0;

        while (i < index && curr != null){
            curr = curr.next;
            ++i;
        }

        if (curr == null || curr.next == null){
            return false;
        }

        var target = curr.next;
        curr.next = target.next;
        
        if (curr.next == null) {
            _tail = curr;
        }

        return true;
    }

    public List<int> GetValues() {
        var values = new List<int>();

        var curr = _head.next;
        while (curr != null){
            values.Add(curr.val);
            curr = curr.next;
        }

        return values;
    }
}