using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DynalistNamespace.DoubleLinkedList;

namespace DynalistNamespace {
  // Задание 1 (классы Utils, Node, DoubleLinkedList)
  public static class Utils {
    public static Node head {
      get;
      set;
    }
    public static Node tail {
      get;
      set;
    }
  }
  public sealed class Node {

    public Node(int v) {
      this.value = v;
      this.previous = null;
      this.next = null;
    }
    public Node() {
      ;
    }
    public int value {
      get;
      set;
    }
    public Node previous {
      get;
      set;
    }
    public Node next {
      get;
      set;
    }
  }
  public class DoubleLinkedList : ILinkedList {
    public void AddNode(int value) {
      Node node = new Node(value);
      if (Utils.head == null) {
        Utils.head = node;
        Utils.tail = node;
        return;
      }
      Utils.tail.next = node;
      node.previous = Utils.tail;
      Utils.tail = node;
    }

    public void AddNodeAfter(Node node, int value) {
      if (node == null) {
        throw new NullReferenceException();
      }

      Node newitem = new Node(value);
      newitem.next = node.next;
      node.next = newitem;
      newitem.previous = node;
      if (newitem.next != null) {
        newitem.next.previous = newitem;
      }
    }

    public void RemoveNode(Node node) {
      if (Utils.head == null || node == null) {
        return;
      }
      if (Utils.head == node) {
        Utils.head = node.next;
      }
      if (node.next != null) {
        node.next.previous = node.previous;
      }
      if (node.previous != null) {
        node.previous.next = node.next;
      }
      return;
    }
    public bool Contains(int key) {
      Node temp = Utils.head;
      while (temp != null) {
        if (temp.value == key) {
           return true;
        }
        temp = temp.next;
      }
      return false;
    }
    public void RemoveNode(int index) {
      if (index < 1) {
        throw new IndexOutOfRangeException();
      
      } else {
        Node temp = new Node();
        temp = Utils.head;
        for (int i = 1; i < index - 1; i++) {
          if (temp != null) {
            temp = temp.next;
          }
        }
        if (temp != null && temp.next != null) {
          Node delnode = temp.next;
          temp.next = temp.next.next;
          if (temp.next.next != null) {
            temp.next.next.previous = temp.next;
          }
          delnode = null;
        } else {
          throw new Exception("Already NULL value");
        }
      }
    }
    public Node FindNode(int searchValue) {
      Node temporary = new Node();
      temporary = Utils.head;
      int f = 0;
      int i = 0;
      if (temporary != null) {
        while (temporary != null) {
          i++;
          if (temporary.value == searchValue) {
            f++;
            return temporary;
          }
          temporary = temporary.next;
        }
        if (f == 1) {
          ;
        } else {
          return new Node(-1);
        }
      } else {
        return new Node(-1);
      }
      return new Node(-1);
    }

    public int GetCount() {
      Node temporaryNode = new Node();
      temporaryNode = Utils.head;
      int i = 0;
      while (temporaryNode != null) {
        i++;
        temporaryNode = temporaryNode.next;
      }
      return i;
    }

    public interface ILinkedList {
      public int GetCount();
      public void AddNode(int value);

      public void AddNodeAfter(Node node, int value);
      public void RemoveNode(int index);
      public void RemoveNode(Node node);
      public Node FindNode(int searchValue);

    }
  }
}
