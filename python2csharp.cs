namespace Namespace {
    
    public static class Module {
        
        public static object i = 0;
        
        public class node {
            
            public node(object k = 0, object p = null, object n = null) {
                this.key = k;
                this.prev = p;
                this.next = n;
            }
        }
        
        public static object head = null;
        
        public static object first = null;
        
        public static object temp = null;
        
        public static object tail = null;
        
        // Function to add a node in the
        // Doubly Linked List
        public static object addnode(object k = @int) {
            // Allocating memory
            // to the Node ptr
            var ptr = node(k);
            // If Linked List is empty
            if (head == null) {
                head = ptr;
                first = head;
                tail = head;
            } else {
                // Else insert at the end of the
                // Linked List
                var temp = ptr;
                first.next = temp;
                temp.prev = first;
                first = temp;
                tail = temp;
            }
            // Increment for number of Nodes
            // in the Doubly Linked List
            i += 1;
        }
        
        // Function to traverse the Doubly
        // Linked List
        public static object traverse() {
            // Nodes points towards head node
            var ptr = head;
            // While pointer is not None,
            // traverse and print the node
            while (ptr != null) {
                // Print key of the node
                Console.WriteLine(ptr.key, end: " ");
                ptr = ptr.next;
            }
            Console.WriteLine();
        }
        
        // Function to insert a node at the
        // beginning of the linked list
        public static object insertatbegin(object k = @int) {
            // Allocating memory
            // to the Node ptr
            var ptr = node(k);
            // If head is None
            if (head == null) {
                first = ptr;
                first = head;
                tail = head;
            } else {
                // Else insert at beginning and
                // change the head to current node
                var temp = ptr;
                temp.next = head;
                head.prev = temp;
                head = temp;
            }
            i += 1;
        }
        
        // Function to insert Node at end
        public static object insertatend(object k = @int) {
            // Allocating memory
            // to the Node ptr
            var ptr = node(k);
            // If head is None
            if (head == null) {
                first = ptr;
                first = head;
                tail = head;
            } else {
                // Else insert at the end
                var temp = ptr;
                temp.prev = tail;
                tail.next = temp;
                tail = temp;
            }
            i += 1;
        }
        
        // Function to insert Node at any
        // position pos
        public static object insertatpos(object k = @int, object pos = @int) {
            // For Invalid Position
            if (pos < 1 || pos > i + 1) {
                Console.WriteLine("Please enter a valid position");
            } else if (pos == 1) {
                // If position is at the front,
                // then call insertatbegin()
                insertatbegin(k);
            } else if (pos == i + 1) {
                // Position is at length of Linked
                // list + 1, then insert at the end
                insertatend(k);
            } else {
                // Else traverse till position pos
                // and insert the Node
                var src = head;
                // Move head pointer to pos
                while (pos) {
                    pos -= 1;
                    src = src.next;
                }
                // Allocate memory to new Node
                var ptr = node(k);
                // Change the previous and next
                // pointer of the nodes inserted
                // with previous and next node
                ptr.next = src;
                ptr.prev = src.prev;
                src.prev.next = ptr;
                src.prev = ptr;
                i += 1;
            }
        }
        
        // Function to delete node at the
        // beginning of the list
        public static object delatbegin() {
            // Move head to next and
            // decrease length by 1
            head = head.next;
            i -= 1;
        }
        
        // Function to delete at the end
        // of the list
        public static object delatend() {
            // Mode tail to the prev and
            // decrease length by 1
            tail = tail.prev;
            tail.next = null;
            i -= 1;
        }
        
        // Function to delete the node at
        // a given position pos
        public static object delatpos(object pos = @int) {
            // If invalid position
            if (pos < 1 || pos > i + 1) {
                Console.WriteLine("Please enter a valid position");
            } else if (pos == 1) {
                // If position is 1, then
                // call delatbegin()
                delatbegin();
            } else if (pos == i) {
                // If position is at the end, then
                // call delatend()
                delatend();
            } else {
                // Else traverse till pos, and
                // delete the node at pos
                // Src node to find which
                // node to be deleted
                var src = head;
                pos -= 1;
                // Traverse node till pos
                while (pos) {
                    pos -= 1;
                    src = src.next;
                }
                // Change the next and prev
                // pointer of pre and aft node
                src.prev.next = src.next;
                src.next.prev = src.prev;
                // Decrease the length of the
                // Linked List
                i -= 1;
            }
        }
        
        static Module() {
            addnode(2);
            addnode(4);
            addnode(9);
            addnode(1);
            addnode(21);
            addnode(22);
            traverse();
            insertatbegin(1);
            traverse();
            insertatend(0);
            traverse();
            insertatpos(44, 3);
            traverse();
            delatbegin();
            traverse();
            delatend();
            traverse();
            delatpos(5);
            traverse();
        }
    }
}
