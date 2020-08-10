//Ho va ten: NguyenHongLoi_LeTriDuc
//Nhom: 8
//Chu de: 9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game123
{
    class GioiThieu:IThongBao,IDisplay
    {
        //Fields
        private string _thongTinGame;
        //Proverty
        public string ThongTinGame { get; set; }
        //Methods
        //Constructor Mac dinh 
        public GioiThieu()
        {
            _thongTinGame = "Người chơi chính (NCC) chọn cấp độ dễ hoặc khó cho câu hỏi.\nHình thức câu hỏi trắc nghiệm với 3 phương án trả lời A, B và C. Với mỗi câu hỏi,\nnhững người cùng chơi còn lại sẽ có 6 giây để nhấn nút A, B, C tương ứng với câu trả lời lựa\nchọn, những người cùng chơi trả lời sai sẽ bị loại khỏi cuộc chơi\n(tương tự như gameshow Rung chuông vàng do cùng có 100 người nhưng không có NCC).";
        }
        //Constructor tham so
        public GioiThieu(string thongtingame)
        {
            this._thongTinGame = thongtingame;
        }
        //GetThong_Tin_Game
        public string GetThongTinGame()
        {
            return this._thongTinGame;
        }
        //toString
        public new string toString()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            string str = $"Giới thiêu game : {_thongTinGame} \n\n\n\t\t\t\tNếu bạn đã hiểu rõ ta bắt dầu chơi";
            Console.ResetColor();
            return str;
        }
        //Dispay
        public void Display()
        {
            Console.WriteLine(toString());
        } 
    }
}
