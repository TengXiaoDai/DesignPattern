using MemorandumModel.Demo;
using MemorandumModel.DemoTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorandumModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //备忘录模式
            //Originator o = new Originator();
            //o.State = "On";
            //o.Show();
            ////创建备忘录保存之前的数据
            //Caretaker c = new Caretaker();
            ////修改之前的数据
            //c.Memento = o.CreateMemento();
            //o.State = "OFF";
            //o.Show();
            ////恢复之前的数据
            //o.SetMemento(c.Memento);
            //o.Show();

            //Work w = new Work();
            //w.State = "上班!";
            //w.Show();
            //Manger m = new Manger();
            //m.menmber = w.SetNew();
            //w.State = "下班";
            //w.Show();
            //w.SetOld(m.menmber);
            //w.Show();

            Person per = new Person();
            per.后悔药 = "幼年";
            per.Show();
            阎王爷 爷 = new 阎王爷();
            爷.数据 = per.刻录时光机器();
            per.后悔药 = "老年";
            per.Show();
            Console.WriteLine("您正在进入老年!是不是觉得还有好多事没做,我现在让你回到幼年！");
            per.回到从前(爷.数据);
            per.Show();

        }
    }
}
