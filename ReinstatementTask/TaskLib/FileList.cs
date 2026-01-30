using System.Drawing;

namespace TaskLib
{
	public class FileList()
    {
		public class Node(int value)
        {
			internal Node? next = null;
			internal Node? prev = null;

            public int Value { get; private set; } = value;
        }

		private Node? head = null;
		private Node? tail = null;

        public int Size { get; private set; } = 0;

		public void Add(int value)
		{
			Node insertNode = new(value);

			if (Size == 0)
			{
				head = insertNode;
				tail = head;
			} 
			else
			{
				tail?.next = insertNode;
				insertNode.prev = tail;
				tail = insertNode;
			}

			Size++;
		}

		public void Clear()
		{
			Node? currNode = head;
			while (currNode != null)
			{
				Node? nextNode = currNode?.next;
				currNode?.prev = null;
				currNode?.next = null;
				currNode = nextNode;
			}

			head = tail = null;
			Size = 0;
		}

		public bool IsEmpty()
		{ 
			return Size == 0; 
		}

		public bool IsSymmetrical()
		{
			if (Size <= 1)
			{
				return true;
			}

			Node? start = head;
			Node? end = tail;

			int size = 1;

			while (size <= Size / 2)
			{
				if (start?.Value != end?.Value)
				{
					return false;
				}

				start = start?.next;
				end = end?.prev;
				size++;
			}

			return true;
		}
    }
}
