using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace linkedlist
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		static class LinkedListUtils<T>
		{

			public static LinkedList<T> sortLinkedList(LinkedList<T> list)
			{
				return new LinkedList<T>(list.OrderBy(x => x)); //сама сортировка
			}

			public static LinkedList<T> merge2LinkedListsAndSort(LinkedList<T> list1, LinkedList<T> list2)
			{
				LinkedList<T> listMerged = new LinkedList<T>();
				foreach (var item in list1)
				{
					listMerged.AddLast(item);
				}
				foreach (var item in list2)
				{
					listMerged.AddLast(item);
				}
				return new LinkedList<T>(listMerged.OrderBy(x => x)); //сама сортировка
			}

			public static void PrintList(LinkedList<T> ll)
			{
				foreach (var obj in ll)
				{
					Console.WriteLine(obj.ToString());
				}
			}

			public static void PrintList(List<T> ll)
			{
				foreach (var obj in ll)
				{
					Console.WriteLine(obj.ToString());
				}
			}
		}

		class Student
		{
			//добавляет имена через конструктор  при создании объекта student
			public string Name { get; set; }

			public Student(string name)
			{
				Name = name;
			}
		}

		class Group
		{
			public List<Student> Students { get; set; }

			public string Id { get; set; }

			public Group(string id)
			{
				Id = id;
				Students = new List<Student>();
			}
		}

		public static void FirstTask()
		{
			LinkedList<string> list = new LinkedList<string>();
			list.AddLast("ITIS");
			list.AddLast("TheWitcher");

			string book = "Почему так много контрольных подряд";
			var temp = list.First;
			while (temp != null)
			{
				if (String.Compare(book, temp.Value, StringComparison.OrdinalIgnoreCase) <= 0 ||
					temp.Next == null)
				{
					list.AddBefore(temp, book);
					break;
				}

				temp = temp.Next;
			}

			while (temp != null)
			{
				Console.WriteLine($"{temp.Value}");
				temp = temp.Next;
			}

		}

		public static void SecondTask()
		{
			LinkedList<int> firstlist = new LinkedList<int>();
			LinkedList<int> secondlist = new LinkedList<int>();
			firstlist.AddLast(9);
			secondlist.AddLast(8);
			firstlist.AddLast(7);
			secondlist.AddLast(6);
			firstlist.AddLast(5);
			secondlist.AddLast(4);
			firstlist.AddLast(3);
			secondlist.AddLast(2);
			firstlist.AddLast(1);
			secondlist.AddLast(0);

			var value = firstlist.Concat(secondlist).OrderByDescending(x => x).ToList();
			var result = new LinkedList<int>(value);

			var temporary = result.First;
			while (temporary != null)
			{
				Console.WriteLine($"{temporary.Value}");
				temporary = temporary.Next;
			}
		}

		public static void ThirdTask()
		{

			// Console.WriteLine($"{temporary.Value}");

			LinkedList<int> list = new LinkedList<int>();
			Random rand = new Random();
			int index = 0;

			for (int i = 0; i < 5; i++)
			{
				list.AddLast(rand.Next(-10, 10));
			}




			LinkedList<int> value = new LinkedList<int>();
			var temporary = list.First;
			while (temporary != null)
			{
				if (temporary.Value > 0 || index % 2 == 0)
				{
					value.AddLast(temporary.Value);
				}

				temporary = temporary.Next;
				index++;
			}
			var result = value.OrderBy(x => x).ToList();
			LinkedList<int> a = new LinkedList<int>(result);
			temporary = a.First;
			while (temporary != null)
			{
				temporary = temporary.Next;
			}
		}


		public static void FourthTask(LinkedList<int> firstlist, LinkedList<int> secondlist)
		{
			var thirdlist = firstlist.Intersect(secondlist).ToList(); 
			if (thirdlist.Count > 0)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
		}


		public static void FifthTask(LinkedList<int> list)
		{
			List<int> beforeinsert = new List<int>();
			List<int> listwithelements = new List<int>(list);
			int i = 0;
			foreach (var item in list)
			{
				beforeinsert.Add(item);
				beforeinsert.AddRange(listwithelements.GetRange(0, i)); 
				i++;                                                                  
			}
			LinkedListUtils<int>.PrintList(beforeinsert);
		}


		public static void SixthTask()
		{
			LinkedList<string> list = new LinkedList<string>() { };
			list.AddLast("itmathrepetitorit");
			list.AddLast("it");
			list.AddLast("math");
			list.AddLast("repetitorit");

			
			string badWord = "itmathrepetitor";
			string goodWord = "silence";

			var temp = list.First;
			while (temp != null)
			{
				temp.Value = TryReplace(temp.Value, badWord, goodWord);
				temp = temp.Next;
			}

		}
		public static void SeventhTask(string filePath)
		{
			string line;
			StreamReader file = new StreamReader(filePath);
			LinkedList<int> strlen = new LinkedList<int>();
			
			while ((line = file.ReadLine()) != null)
			{
				strlen.AddLast(line.Length);
			}
			LinkedListUtils<int>.PrintList(strlen);
		}

		public static void EightTask()
		{
			LinkedList<Group> group1 = new LinkedList<Group>();

			Group g1 = new Group("11-301");
			Student g1s1 = new Student("gp1St1");
			Student g1s2 = new Student("gp1St2");
			g1.Students.Add(g1s1);
			g1.Students.Add(g1s2);

			Group gp2 = new Group("11-302");
			Student g2s1 = new Student("gp2St1");
			Student g2s2 = new Student("gp2St2");
			gp2.Students.Add(g2s1);
			gp2.Students.Add(g2s2);

			group1.AddLast(g1);
			group1.AddLast(gp2);

			foreach (var group in group1)
			{
				Console.WriteLine(group.Id);
				foreach (var student in group.Students)
				{
					Console.WriteLine("Name - " + student.Name);
				}
				Console.WriteLine();
			}
		}


		private static string TryReplace(string temp, string b, string g)
		{
			return temp.Replace(b, g);
		}





	}
}
