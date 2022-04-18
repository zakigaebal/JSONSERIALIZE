using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONSERIALIZE
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// 테스트용 JSON string 만들기
			var p = new { Id = 1, Name = "Alex", Address = new { City = "Redmond", State = "WA", Zip = "98052" } };
			string jsonString = JsonConvert.SerializeObject(p);
			txtOriginal.Text = jsonString;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string jsonString = txtOriginal.Text;
			// JSON string을 보기 좋게 만듦
			txtBeautified.Text = Beautify(jsonString);

		}
		private string Beautify(string jsonString)
		{
			dynamic json = JsonConvert.DeserializeObject(jsonString);
			return JsonConvert.SerializeObject(json, Formatting.Indented);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			dynamic json = JsonConvert.DeserializeObject(txtOriginal.Text);
			//int count = jObj.Count;
			textBox1.Text = json.Name;
			textBox2.Text = json.Address.City;

			//foreach (var package in jObj)
			//{
			//	Console.WriteLine("{0}, {1}", package.First, package.Name);
			//}

			dynamic stuff;
			int count = 0;
			stuff = JsonConvert.DeserializeObject(txtOriginal.Text);
			foreach (JProperty s in stuff)
			{

				count++;
			Console.WriteLine(s.First.ToString());
			}

			Console.WriteLine(count.ToString());

			//Console.WriteLine(d.Name);
			//Console.WriteLine(d.Address.City);
			//Console.WriteLine(d.array.Count);
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void labelNAME_Click(object sender, EventArgs e)
		{

		}
	}
}
//JObject jObj = (JObject)JsonConvert.DeserializeObject(myJsonString);
//int count = jObj.Count;
//	dynamic jObj = JsonConvert.DeserializeObject(txtOriginal.Text);

//string jsonString = txtOriginal.Text;
//JObject jObj = (JObject)JsonConvert.DeserializeObject(jsonString);
//int count = jObj.Count;
//for (int i = 0; i < count-1; i++)
//{

//}