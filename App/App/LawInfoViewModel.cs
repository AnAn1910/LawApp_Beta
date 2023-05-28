using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App
{
    public class LawInfoViewModel
    {

        public ObservableCollection<LawInfo>  ItemList { get; set; }
        public ObservableCollection<LawInfo> ListChapter1 { get; set; }
        public ObservableCollection<LawInfo> ListChapter2 { get; set; }
        public ObservableCollection<LawInfo> ListChapter3 { get; set; }
        public ObservableCollection<LawInfo> ListChapter4 { get; set; }
        public ObservableCollection<LawInfo> ListChapter5 { get; set; }
        public ObservableCollection<LawInfo> LawSections1 { get; set; }
        public ObservableCollection<LawInfo> LawSections2 { get; set; }
        public ObservableCollection<LawInfo> LawSections3 { get; set; }
        public ObservableCollection<LawInfo> LawSections4 { get; set; }
        public ObservableCollection<LawInfo> LawSections5 { get; set; }

        public LawInfoViewModel() 
        { 
            ItemList = new ObservableCollection<LawInfo> ();
            ItemList.Add(new LawInfo() { LawId = 1, LawName = "Chương I: Áp dụng xử phạt vi phạm hành chính" });
            ItemList.Add(new LawInfo() { LawId = 2, LawName = "Chương II: Vi phạm quy định về quản lý rừng và sử dụng rừng " });
            ItemList.Add(new LawInfo() { LawId = 3, LawName = "Chương III: Vi phạm quy định về Phát triển rừng, bảo vệ rừng" });
            ItemList.Add(new LawInfo() { LawId = 4, LawName = "Chương IV: Vi phạm quy định quản lý lâm sản" });
            ItemList.Add(new LawInfo() { LawId = 5, LawName = "Chương V: Thẩm quyền xử phạt vi phạm hành chính" });

            ListChapter1 = new ObservableCollection<LawInfo>();
            ListChapter1.Add(new LawInfo() { LawArticlesId = 1, LawArticlesName = "Điều 6. Áp dụng xử phạt vi phạm hành chính" });

            ListChapter2 = new ObservableCollection<LawInfo>();
            ListChapter2.Add(new LawInfo() { LawArticlesId = 1, LawArticlesName = "Điều 7. Lấn, chiếm rừng" });
            ListChapter2.Add(new LawInfo() { LawArticlesId = 2, LawArticlesName = "Điều 8. Khai thác trái phép môi trường rừng và thực hiện các dịch vụ, kinh doanh trái phép trong rừng" });
            ListChapter2.Add(new LawInfo() { LawArticlesId = 3, LawArticlesName = "Điều 9. Vi phạm quy định về chi trả dịch vụ môi trường rừng" });
            ListChapter2.Add(new LawInfo() { LawArticlesId = 4, LawArticlesName = "Điều 10. Vi phạm quy định về quản lý rừng bền vững" });
            ListChapter2.Add(new LawInfo() { LawArticlesId = 5, LawArticlesName = "Điều 11. Vi phạm quy định về hồ sơ, thủ tục khai thác lâm sản có nguồn gốc hợp pháp" });
            ListChapter2.Add(new LawInfo() { LawArticlesId = 6, LawArticlesName = "Điều 12. Vi phạm quy định về chuyển mục đích sử dụng rừng" });
            ListChapter2.Add(new LawInfo() { LawArticlesId = 7, LawArticlesName = "Điều 13. Khai thác rừng trái pháp luật" });
        
            ListChapter3 = new ObservableCollection<LawInfo>();
            ListChapter3.Add(new LawInfo() { LawArticlesId = 1, LawArticlesName = "Điều 14. Vi phạm quy định về quản lý giống cây trồng lâm nghiệp" });
            ListChapter3.Add(new LawInfo() { LawArticlesId = 2, LawArticlesName = "Điều 15. Vi phạm quy định về trồng rừng thay thế" });
            ListChapter3.Add(new LawInfo() { LawArticlesId = 3, LawArticlesName = "Điều 16. Vi phạm các quy định chung của Nhà nước về bảo vệ rừng" });
            ListChapter3.Add(new LawInfo() { LawArticlesId = 4, LawArticlesName = "Điều 17. Vi phạm các quy định của pháp luật về phòng cháy và chữa cháy rừng gây cháy rừng" });
            ListChapter3.Add(new LawInfo() { LawArticlesId = 5, LawArticlesName = "Điều 18. Vi phạm quy định về phòng trừ sinh vật hại rừng" });
            ListChapter3.Add(new LawInfo() { LawArticlesId = 6, LawArticlesName = "Điều 19. Phá hủy các công trình bảo vệ và phát triển rừng" });
            ListChapter3.Add(new LawInfo() { LawArticlesId = 7, LawArticlesName = "Điều 20. Phá rừng trái pháp luật" });
            ListChapter3.Add(new LawInfo() { LawArticlesId = 8, LawArticlesName = "Điều 21. Vi phạm các quy định về bảo vệ động vật rừng" });

            ListChapter4 = new ObservableCollection<LawInfo>();
            ListChapter4.Add(new LawInfo() { LawArticlesId = 1, LawArticlesName = "Điều 22. Vận chuyển lâm sản trái pháp luật" });
            ListChapter4.Add(new LawInfo() { LawArticlesId = 2, LawArticlesName = "Điều 23. Tàng trữ, mua bán, xuất khẩu, nhập khẩu, chế biến lâm sản trái pháp luật" });
            ListChapter4.Add(new LawInfo() { LawArticlesId = 3, LawArticlesName = "Điều 24. Vi phạm quy định về quản lý hồ sơ lâm sản trong vận chuyển, mua bán, cất giữ, chế biến lâm sản" });

            ListChapter5 = new ObservableCollection<LawInfo>();
            ListChapter5.Add(new LawInfo() { LawArticlesId = 1, LawArticlesName = "Điều 25. Thẩm quyền lập biên bản vi phạm hành chính" });
            ListChapter5.Add(new LawInfo() { LawArticlesId = 2, LawArticlesName = "Điều 26. Thẩm quyền xử phạt vi phạm hành chính của Kiểm lâm" });
            ListChapter5.Add(new LawInfo() { LawArticlesId = 3, LawArticlesName = "Điều 27. Thẩm quyền xử phạt vi phạm hành chính của Chủ tịch Ủy ban nhân dân các cấp" });
            ListChapter5.Add(new LawInfo() { LawArticlesId = 4, LawArticlesName = "Điều 28. Thẩm quyền xử phạt vi phạm hành chính của thanh tra chuyên ngành trong lĩnh vực Lâm nghiệp" });
            ListChapter5.Add(new LawInfo() { LawArticlesId = 5, LawArticlesName = "Điều 29. Thẩm quyền xử phạt của Công an nhân dân" });
            ListChapter5.Add(new LawInfo() { LawArticlesId = 6, LawArticlesName = "Điều 30. Thẩm quyền xử phạt của Bộ đội Biên phòng" });
            ListChapter5.Add(new LawInfo() { LawArticlesId = 7, LawArticlesName = "Điều 31. Thẩm quyền xử phạt của Cảnh sát biển" });
            ListChapter5.Add(new LawInfo() { LawArticlesId = 8, LawArticlesName = "Điều 32. Thẩm quyền xử phạt của Quản lý thị trường" });
            ListChapter5.Add(new LawInfo() { LawArticlesId = 9, LawArticlesName = "Điều 33. Thẩm quyền xử phạt vi phạm hành chính của Hải quan" });
            ListChapter5.Add(new LawInfo() { LawArticlesId = 10, LawArticlesName = "Điều 34. Phân định thẩm quyền xử phạt" });
            ListChapter5.Add(new LawInfo() { LawArticlesId = 11, LawArticlesName = "Điều 35. Xác định thẩm quyền xử phạt vi phạm hành chính" });

            LawSections1 = new ObservableCollection<LawInfo>();
            LawSections1.Add(new LawInfo() { LawSectionsId = 1, LawSectionsName = "1. Mức phạt tiền đối với hành vi vi phạm hành chính quy định tại Nghị định này là mức phạt tiền được áp dụng đối với cá nhân, mức phạt tiền tối đa trong lĩnh vực Lâm nghiệp đối với cá nhân là 500.000.000 đồng; tổ chức vi phạm áp dụng phạt tiền bằng 2 lần mức phạt tiền với cá nhân có cùng hành vi và mức độ vi phạm, mức phạt tiền tối đa trong lĩnh vực Lâm nghiệp đối với tổ chức là 1.000.000.000 đồng." });
            LawSections1.Add(new LawInfo() { LawSectionsId = 2, LawSectionsName = "2. Hành vi vi phạm hành chính đối với gỗ, thực vật rừng ngoài gỗ thuộc Danh mục loài nguy cấp, quý, hiếm được ưu tiên bảo vệ, thì áp dụng xử phạt hành vi vi phạm như đối với gỗ, thực vật rừng ngoài gỗ thuộc Danh mục thực vật rừng, động vật rừng nguy cấp, quý, hiếm Nhóm IA." });
            LawSections1.Add(new LawInfo() { LawSectionsId = 3, LawSectionsName = "3. Hành vi vi phạm hành chính đối với các loài thuộc Phụ lục I Công ước về buôn bán quốc tế  các loài động vật, thực vật hoang dã nguy cấp, thì áp dụng xử phạt hành vi vi phạm như đối với thực vật rừng, động vật rừng thuộc Danh mục thực vật rừng, động vật rừng nguy cấp, quý, hiếm Nhóm I. Hành vi vi phạm hành chính đối với các loài thuộc Phụ lục II Công ước về buôn bán quốc tế các loài động vật, thực vật hoang dã nguy cấp, thì áp dụng Xử phạt hành vi vi phạm như đối với thực vật rừng, động vật rừng thuộc Danh mục thực vật rừng, động vật rừng nguy cấp, quý, hiếm Nhóm II." });
            LawSections1.Add(new LawInfo() { LawSectionsId = 4, LawSectionsName = "4. Hành vi vi phạm đối với động vật rừng thuộc Danh mục thực vật rừng, động vật rừng nguy cấp, quý, hiếm Nhóm IB, IIB  hoặc động vật hoang dã thuộc Phụ lục I, II Công ước về buôn bán quốc tế các loài động vật, thực vật hoang dã nguy cấp nhưng thuộc Danh mục loài nguy cấp, quý, hiếm được ưu tiên bảo vệ, thì áp dụng xử lý như động vật thuộc Danh mục loài nguy cấp, quý, hiếm được ưu tiên bảo vệ.Hành vi vi phạm hành chính đối với động vật hoang dã trên cạn khác hoặc động vật hoang dã nguy cấp thuộc Phụ lục III Công ước về buôn bán quốc tế các loài động vật, thực vật hoang dã nguy cấp thì áp dụng xử phạt như đối với động vật rừng thông thường. Trường hợp hành vi vi phạm đối với động vật hoang dã trên cạn khác trị giá từ 300.000.000 đồng trở lên thì áp dụng khung tiền phạt cao nhất như đối với động vật rừng thông thường; áp dụng hình thức phạt bổ sung và biện pháp khắc phục hậu quả tương ứng với khung phạt đó." });
            LawSections1.Add(new LawInfo() { LawSectionsId = 5, LawSectionsName = "5. Hành vi vi phạm thuộc vụ việc do cơ quan có thẩm quyền tiến hành tố tụng hình sự thụ lý, giải quyết chuyển đến để xử phạt hành chính theo quy định tại Điều 63 Luật Xử lý vi phạm hành chính thì căn cứ tính chất, mức độ, hậu quả vi phạm, đối tượng vi phạm và các tình tiết tăng nặng, giảm nhẹ để áp dụng khung tiền phạt, hình thức phạt bổ sung và biện pháp khắc phục hậu quả tương ứng với hành vi vi phạm đó để xử phạt. Trường hợp hành vi vi phạm hành chính gây hậu quả vượt quá mức hậu quả quy định tại khung tiền phạt cao nhất đối với hành vi vi phạm đó thì áp dụng khung tiền phạt cao nhất, hình thức phạt bổ sung và biện pháp khắc phục hậu quả tương ứng với khung phạt đó để xử phạt.Trường hợp tang vật vi phạm là động vật, bộ phận cơ thể, sản phẩm của động vật thuộc Danh mục loài nguy cấp, quý, hiếm được ưu tiên bảo vệ thì áp dụng xử phạt như động vật rừng thuộc Danh mục thực vật rừng, động vật rừng nguy cấp, quý, hiếm Nhóm IB." });
            LawSections1.Add(new LawInfo() { LawSectionsId = 6, LawSectionsName = "6. Trường hợp một hành vi vi phạm hành chính gây thiệt hại nhiều loại rừng: rừng sản xuất, rừng phòng hộ, rừng đặc dụng hoặc tang vật vi phạm gồm nhiều loại lâm sản khác nhau nhưng chưa đến mức truy cứu trách nhiệm hình sự, thì xác định tiền phạt của hành vi vi phạm theo từng loại rừng hoặc từng loại lâm sản." });

        }
    }
}
