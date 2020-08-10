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
     class CauHoi : TroGiup
    {
        //Fields
        private int _soCauHoi;
        private int _score;
        //Proverties
        //Proverty socauhoi
        public int SoCauHoi
        {
            get
            {
                return _soCauHoi;
            }

            set
            {
                _soCauHoi = value;
            }
        }
        //Proverty diem
        public int Score
        {
            get
            {
                return _score;
            }

            set
            {
                _score = 0;
            }
        }
        //Constructor mac dinh
        public CauHoi()
        {
            _soCauHoi = 0;
            _score = 0;
        }
        //GetDiem
        public int GetDiem()
        {
            return this._score;
        }
        //SetDiem
        public void SetDiem(int diem)
        {
            this._score = Score;
        }
        //Xu ly cau hoi
        public void Question()
        {
            //Khai bao bien Random
            bool playAgain = true;
            //truong hop vong lap neu thua 
            while (playAgain)
            {
                Random rd = new Random();
                int r = rd.Next(1, 21);//Gọi r là số người bị loại câu hỏi
                int t = 100;//Gọi t là tổng số người chơi còn lại
                _score = 0;   //Diem
                _soCauHoi = 0;//So cau hoi
                ThongBao tb = new ThongBao();
               
                //Cau hoi 1
                char a;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("************************************************************************");
                Console.Write("\n\t\tCau hoi 1) Cây ngay không sợ...? \n \n\t\t\tA) Chết thắng  \n\t\t\tB) Chết đứng \n\t\t\tC) Chết cong \n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nMời bạn chọn:  ");
                char.TryParse(Console.ReadLine(), out a);
                switch (a)
                {
                    //truong hop sai
                    case 'A':
                    case 'a':
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Bạn đã sai >> Đáp án là B");
                        Console.ResetColor();
                        break;
                    //truong hop dung
                    case 'B':
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Bạn đã đúng ");
                        Console.ResetColor();
                        _soCauHoi++;//Nếu trả lời đúng thì qua câu hỏi tiêp theo và random loại bỏ số người chơi
                        r = rd.Next(1, 21);
                        t -= r;
                        Console.WriteLine("_____________________________________________________________________________________");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                        Console.WriteLine("_____________________________________________________________________________________");
                        Console.BackgroundColor = ConsoleColor.Black;
                        //Điểm sẽ được tính theo công thức =1000/(so nguoi truoc cau hoi * so nguoi bi loai sau cau hoi)
                        _score += ((1000 / t) * r);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                    //truong hop sai
                    case 'C':
                    case 'c':
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Bạn đã sai >> Đáp án là B");
                        Console.ResetColor();
                        break;
                    //Truong hop nhap sai ky tu
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Bạn đã nhập sai ký tự >>> Error");
                        Console.ResetColor();
                        break;
                }
                //Cau hoi 2
                char b;
                if (_soCauHoi == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("************************************************************************");
                    Console.Write("\n\t\tCau hoi 2) Sat trong tiếng Anh là thứ mấy trong tuần? \n \n\t\t\tA) Thứ hai  \n\t\t\tB) Thứ ba \n\t\t\tC) Thứ Bảy ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                    char.TryParse(Console.ReadLine(), out b);
                    switch (b)
                    {
                        //truong hop sai
                        case 'A':
                        case 'a':
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Bạn đã sai >> Đáp án là C");
                            Console.ReadKey();
                            Console.ResetColor();
                            break;
                        //truong hop sai
                        case 'B':
                        case 'b':
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Bạn đã sai >> Đáp án là C");
                            Console.ResetColor();
                            break;
                        //truong hop dung
                        case 'C':
                        case 'c':
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Bạn đã đúng ");
                            Console.ResetColor();
                            _soCauHoi++;
                            r = rd.Next(1, 21);
                            t -= r;
                            Console.WriteLine("_____________________________________________________________________________________");
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                            Console.WriteLine("_____________________________________________________________________________________");
                            Console.BackgroundColor = ConsoleColor.Black;
                            _score += ((1000 / t) * r);
                            Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        //Truong hop nhan phim bta ky de co su tro giup 
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            trogiup(ref _score, ref _soCauHoi);
                            Console.ReadKey();
                            break;
                    }
                }

                //Cau hoi 3
                char c;
                if (_soCauHoi == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("************************************************************************");
                    Console.Write("\n\t\tCau hoi 3) Đố bạn chuột nào đi bằng 2 chân? \n \n\t\t\tA) Chuột đồng  \n\t\t\tB) Chuột Logitech \n\t\t\tC) Chuột Mickey \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                    char.TryParse(Console.ReadLine(), out c);
                    switch (c)
                    {
                        //Truong hop sai
                        case 'A':
                        case 'a':
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Bạn đã sai >> Đáp án là C");
                            Console.ReadKey();
                            Console.Clear();
                            Console.ResetColor();
                            break;
                        //truong hop sai
                        case 'B':
                        case 'b':
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Bạn đã sai >> Đáp án là C");
                            Console.ResetColor();
                            break;
                        //truong hop dung
                        case 'C':
                        case 'c':
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Bạn đã đúng ");
                            Console.ResetColor();
                            _soCauHoi++;
                            r = rd.Next(1, 21);
                            t -= r;
                            Console.WriteLine("_____________________________________________________________________________________");
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                            Console.WriteLine("_____________________________________________________________________________________");
                            Console.BackgroundColor = ConsoleColor.Black;
                            _score += ((1000 / t) * r);

                            Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        //truong hop nhan phim bat ky de chon tro giup
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            trogiup(ref _score, ref _soCauHoi);
                            Console.ReadKey();
                            break;
                    }
                    
                    //Cau hoi 4
                    char d;
                    if (_soCauHoi == 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 4) Sở thú bị cháy ,đố bạn con gì chạy ra đầu tiên? \n \n\t\t\tA) Con Người  \n\t\t\tB) Con sư tử \n\t\t\tC) Con Khỉ \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out d);
                        switch (d)
                        {
                            //truong hop dung
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                Console.WriteLine("_____________________________________________________________________________________");
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                Console.WriteLine("_____________________________________________________________________________________");
                                Console.BackgroundColor = ConsoleColor.Black;
                                _score += ((1000 / t) * r);

                                Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            //truong hop sai
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                break;
                            //truong hop sai
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                break;
                            //truong hop nhan phim bat ky de co su tro giup
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }

                    }
                
                    //Cau hoi 5
                    char e;
                    if (_soCauHoi == 4)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 5) Bạn làm việc gì đầu tiên mỗi buổi sáng? \n \n\t\t\tA) Mở mắt  \n\t\t\tB) Đánh răng \n\t\t\tC) Đi học  \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out e);
                        switch (e)
                        {
                            //truong hop dung
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                Console.WriteLine("_____________________________________________________________________________________");
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                Console.WriteLine("_____________________________________________________________________________________");
                                Console.BackgroundColor = ConsoleColor.Black;
                                _score += ((1000 / t) * r);
                                Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            //truong hop sai
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                Console.ResetColor();
                                break;
                            //truong hop sai
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                Console.ResetColor();
                                break;
                            //truong hop nhan phim bat ky de co su tro giup
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }

                    }
                  
                    //Cau hoi 6
                    char f;
                    //Vi random (1>20) nguoi bi loai nen neu so nguoi lon hon 1 thi se thuc hien tiep cau lenh khong thi ket thuc chuong trinh 
                    if (_soCauHoi == 5 && t > 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 6) Đố bạn khi Beckham thực hiện quả đá phạt đền, anh ta sẽ sút vào đâu? \n \n\t\t\tA) Vào bóng  \n\t\t\tB) Vào khung thành \n\t\t\tC) Vào lưới  \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out f);
                        switch (f)
                        {
                            //truong hop dung
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                //Xet truong hop neu so nguoi con lai < 1 thi tra ve ket qua 
                                if (t < 1 || _score < 0)
                                {
                                    _soCauHoi = 15;
                                }
                                else
                                {
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    _score += ((1000 / t) * r);
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                break;
                            //truong hop sai
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                Console.ResetColor();
                                break;
                            //truong hop sai
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                Console.ResetColor();
                                break;
                            //truong hop nhan phim bat ky de co su tro giup
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }

                    }
                    else
                    {
                        _soCauHoi = 15;
                    }
                
                    //Cau hoi 7
                    char g;
                    //Vi random (1>20) nguoi bi loai nen neu so nguoi lon hon 1 thi se thuc hien tiep cau lenh khong thi ket thuc chuong trinh 
                    if (_soCauHoi == 6 && t > 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 7)  Điều gì luôn đến, nhưng không bao giờ đến? \n \n\t\t\tA) Tình yêu  \n\t\t\tB) Ngày mai \n\t\t\tC) Trong mơ  \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out g);
                        switch (g)
                        {
                            //truong hop sai
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là B");
                                Console.ResetColor();
                                break;
                            //truong hop dung
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                //Xet truong hop neu so nguoi con lai < 1 thi tra ve ket qua 
                                if (t < 1 || _score < 0)
                                {
                                    _soCauHoi = 15;
                                }
                                else
                                {
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    _score += ((1000 / t) * r);
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                break;
                            //truong hop sai
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là B");
                                Console.ResetColor();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }

                    }
                    else
                    {
                        _soCauHoi = 15;
                    }
                 
                    //Cau hoi 8
                    char h;
                    //Vi random (1>20) nguoi bi loai nen neu so nguoi lon hon 1 thi se thuc hien tiep cau lenh khong thi ket thuc chuong trinh 
                    if (_soCauHoi == 7 && t > 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 8) Một ly thuỷ tinh đựng đầy nước, làm thế nào để lấy \n\t\t\tnước dưới đáy ly mà không đổ nước ra ngoài ? \n\n \t\t\tA) Dùng đá lấp đầy   \n\t\t\tB) Dùng ống hút  \n\t\t\tC) Phá vỡ chiếc ly \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out h);
                        switch (h)
                        {
                            //truong hop sai
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là B");
                                Console.ResetColor();
                                break;
                            //truong hop dung
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                //Xet truong hop neu so nguoi con lai < 1 thi tra ve ket qua 
                                if (t < 1 || _score < 0)
                                {
                                    _soCauHoi = 15;
                                }
                                else
                                {
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    _score += ((1000 / t) * r);
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                break;
                            //truong hop sai
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là B");
                                Console.ResetColor();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }

                    }
                    else
                    {
                        _soCauHoi = 15;
                    }
                 
                    //Cau hoi 9
                    char j;
                    //Vi random (1>20) nguoi bi loai nen neu so nguoi lon hon 1 thi se thuc hien tiep cau lenh khong thi ket thuc chuong trinh 
                    if (_soCauHoi == 8 && t > 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 9) Đố bạn có bao nhiêu chữ C trong câu sau đây: “ Cơm, canh, cháo gì tớ cũng thích ăn!” . \n \n\t\t\tA) 1   \n\t\t\tB) 2 \n\t\t\tC) 3  \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out j);
                        switch (j)
                        {
                            //truong hop dung
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                //Xet truong hop neu so nguoi con lai < 1 thi tra ve ket qua 
                                if (t < 1 || _score < 0)
                                {
                                    _soCauHoi = 15;
                                }
                                else
                                {
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    _score += ((1000 / t) * r);
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                break;
                            //truong hop sai
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                Console.ResetColor();
                                break;
                            //truong hop sai
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                Console.ResetColor();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        _soCauHoi = 15;
                    }
              
                    //Cau hoi 10
                    char z;
                    //Vi random (1>20) nguoi bi loai nen neu so nguoi lon hon 1 thi se thuc hien tiep cau lenh khong thi ket thuc chuong trinh 
                    if (_soCauHoi == 9 && t > 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 10) Cái gì người mua biết, người bán biết, người xài không bao giờ biết? \n \n\t\t\tA) Cái bút bi  \n\t\t\tB) Nước đá \n\t\t\tC) Quan tài  \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out z);
                        switch (z)
                        {
                            //truong hop sai
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là C");
                                Console.ResetColor();
                                break;
                            //truong hop sai
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là C");
                                Console.ResetColor();
                                break;
                            //truong hop dung
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                //Xet truong hop neu so nguoi con lai < 1 thi tra ve ket qua 
                                if (t < 1 || _score < 0)
                                {
                                    _soCauHoi = 15;
                                }
                                else
                                {
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    _score += ((1000 / t) * r);
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }

                    }
                    else
                    {
                        _soCauHoi = 15;
                    }
                  
                    //Cau hoi so 11
                    char x;
                    //Vi random (1>20) nguoi bi loai nen neu so nguoi lon hon 1 thi se thuc hien tiep cau lenh khong thi ket thuc chuong trinh 
                    if (_soCauHoi == 10 && t > 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 11) Cũng trong một cuộc đua, bạn vừa chạy qua người cuối cùng. Vậy bạn đang ở vị trí nào? \n \n\t\t\tA) Đầu tiên  \n\t\t\tB) Ở giữa \n\t\t\tC) Cuối cùng  \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out x);
                        switch (x)
                        {
                            //truong hop sai
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là C");
                                Console.ResetColor();
                                break;
                            //truong hop sai
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là C");
                                Console.ResetColor();
                                break;
                            //truong hop dung
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                //Xet truong hop neu so nguoi con lai < 1 thi tra ve ket qua 
                                if (t < 1 || _score < 0)
                                {
                                    _soCauHoi = 15;
                                }
                                else
                                {
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    _score += ((1000 / t) * r);
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        _soCauHoi = 15;
                    }
                 
                    //Cau hoi so 12
                    char y;
                    //Vi random (1>20) nguoi bi loai nen neu so nguoi lon hon 1 thi se thuc hien tiep cau lenh khong thi ket thuc chuong trinh 
                    if (_soCauHoi == 11)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 12) Con mèo nào cực kỳ sợ chuột? \n \n\t\t\tA) Mèo vàn  \n\t\t\tB) Doraemon \n\t\t\tC) Mèo bị bệnh \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out y);
                        switch (y)
                        {
                            //truong hop sai
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là B");
                                Console.ResetColor();
                                break;
                            //truong hop dung
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                //Xet truong hop neu so nguoi con lai < 1 thi tra ve ket qua 
                                if (t < 1 || _score < 0)
                                {
                                    _soCauHoi = 15;
                                }
                                else
                                {
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    _score += ((1000 / t) * r);
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                break;
                            //truong hop sai
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là B");
                                Console.ResetColor();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }

                    }
                    else
                    {
                        _soCauHoi = 15;
                    }
               
                    //Cau hoi so 13
                    char n;
                    //Vi random (1>20) nguoi bi loai nen neu so nguoi lon hon 1 thi se thuc hien tiep cau lenh khong thi ket thuc chuong trinh 
                    if (_soCauHoi == 12 && t > 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 13) Người đàn ông duy nhất trên thế giới có…sữa là ai? \n \n\t\t\tA) Ông Ba  \n\t\t\tB) Lão Hạc \n\t\t\tC) Ông Thọ  \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out n);
                        switch (n)
                        {
                            //truong hop sai
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là C");
                                Console.ResetColor();
                                break;
                            //truong hop sai
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là C");
                                Console.ResetColor();
                                break;
                            //truong hop dung
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                //Xet truong hop neu so nguoi con lai < 1 thi tra ve ket qua 
                                if (t < 1 || _score < 0)
                                {
                                    _soCauHoi = 15;
                                }
                                else
                                {
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    _score += ((1000 / t) * r);
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        _soCauHoi = 15;
                    }
              
                    //Cau hoi so 14
                    char k;
                    //Vi random (1>20) nguoi bi loai nen neu so nguoi lon hon 1 thi se thuc hien tiep cau lenh khong thi ket thuc chuong trinh 
                    if (_soCauHoi == 13 && t > 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 14)  Phương tiện nào được sử dụng trong bài hát (12 giờ)? \n \n\t\t\tA) Xe đạp  \n\t\t\tB) Xe máy \n\t\t\tC) Xe ô tô  \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out k);
                        switch (k)
                        {
                            //truong hop dung
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                //Xet truong hop neu so nguoi con lai < 1 thi tra ve ket qua 
                                if (t < 1 || _score < 0)
                                {
                                    _soCauHoi = 15;
                                }
                                else
                                {
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    _score += ((1000 / t) * r);
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                break;
                            //truong hop sai
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                Console.ResetColor();
                                break;
                            //truong hop sai
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                Console.ResetColor();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }

                    }
                    else
                    {
                        _soCauHoi = 15;
                    }
                  
                    //Câu hỏi số 15
                    char p;
                    //Vi random (1>20) nguoi bi loai nen neu so nguoi lon hon 1 thi se thuc hien tiep cau lenh khong thi ket thuc chuong trinh 
                    if (_soCauHoi == 14 && t > 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("************************************************************************");
                        Console.Write("\n\t\tCau hoi 15)  Con gì biết đi nhưng người ta vẫn nói nó không biết đi? \n \n\t\t\tA) Con Bò  \n\t\t\tB) Con trâu \n\t\t\tC) Con người \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nMời bạn chọn hoặc nhấn phím bất kỳ để trợ giúp:  ");
                        char.TryParse(Console.ReadLine(), out p);
                        switch (p)
                        {
                            case 'A':
                            case 'a':
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã đúng ");
                                Console.ResetColor();
                                _soCauHoi++;
                                r = rd.Next(1, 21);
                                t -= r;
                                //Xet truong hop neu so nguoi con lai < 1 thi tra ve ket qua 
                                if (t < 1 || _score < 0)
                                {
                                    _soCauHoi = 15;
                                }
                                else
                                {
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  Số người chơi hiện tại ({0})\t\t\t\tSố người chơi bị loại ({1})   ", t, r);
                                    Console.WriteLine("_____________________________________________________________________________________");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    _score += ((1000 / t) * r);
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);
                                    Console.ResetColor();
                                    Console.ReadKey();

                                }
                                break;
                            case 'B':
                            case 'b':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                Console.ResetColor();
                                break;
                            case 'C':
                            case 'c':
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Bạn đã sai >> Đáp án là A");
                                Console.ResetColor();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Green;
                                trogiup(ref _score, ref _soCauHoi);
                                Console.ReadKey();
                                break;
                        }

                    }
                    else
                    {
                        _soCauHoi = 15;
                    }
                  
                    //Truong hop nguoi choi chien thang
                    if (_soCauHoi == 15)
                    {

                        Console.WriteLine("_____________________________________________________________________________________");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("  Bạn đã chiến thắng với 100 người cùng chơi  ");
                        Console.ResetColor();
                        //Neu ket qua tra ve la so am chuyen  thanh duong
                        if (_score < 0)
                        {
                            _score *= -1;
                        }
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t Điểm : {0}", _score);

                        Console.ReadKey();
                    }
                    else if (_soCauHoi == 20)
                    {
                        Console.WriteLine("Ban da thua ");
                    }
                }

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Bạn muốn tiếp chơi không?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y" || loop == "Y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n" || loop == "N")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }
    }
}
