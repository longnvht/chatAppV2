using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace chat_app.Views.Controls
{
    [ComplexBindingProperties("DataSource", "DataMember")]
    public partial class ChatList : UserControl
    {
        private int scrWidth = SystemInformation.VerticalScrollBarWidth;
        private string dataMember;
        private BindingSource bindingSource;


        // Khai báo một sự kiện để thông báo khi có sự thay đổi trong DataSource hoặc DataMember
        public event EventHandler DataSourceChanged;

        // Khai báo một sự kiện để thông báo khi người dùng nhấn vào một item trong user control
        public event EventHandler ItemClicked;
        public ChatList()
        {
            InitializeComponent();
            flpChatList.SizeChanged += ChatList_SizeChanged;
        }

        private void ChatList_SizeChanged(object sender, EventArgs e)
        {
            ChangeItemSize();
        }

        private void ChangeItemSize()
        {

            foreach (ChatListItem chatItem in flpChatList.Controls.OfType<ChatListItem>())
            {
                chatItem.Width = flpChatList.Width - 10 - scrWidth;
            }
        }

        [AttributeProvider(typeof(IListSource))]

        // Lấy hoặc gán giá trị cho thuộc tính DataMember
        public string DataMember
        {
            get { return dataMember; }
            set
            {
                if (dataMember != value)
                {
                    dataMember = value;
                    // Gọi phương thức BindData để hiển thị dữ liệu lên các item
                    BindData();
                    // Nếu có sự kiện DataSourceChanged thì gọi nó
                    if (DataSourceChanged != null)
                    {
                        DataSourceChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        // Lấy hoặc gán giá trị cho thuộc tính DataSource
        public BindingSource DataSource
        {
            get { return bindingSource; }
            set
            {
                bindingSource = value;
                if (bindingSource != null) { bindingSource.ListChanged += BindingSource_ListChanged; }
            }
        }

        private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            BindData();
        }

        // Phương thức để hiển thị dữ liệu lên các item trong user control
        private void BindData()
        {
            // Xóa tất cả các item cũ trong panel
            flpChatList.Controls.Clear();

            // Nếu không có dữ liệu hoặc tên cột hoặc thuộc tính thì thoát khỏi phương thức
            if (bindingSource == null || bindingSource.Count < 1) return;

            // Duyệt qua từng đối tượng trong danh sách dữ liệu
            foreach (var item in bindingSource)
            {
                // Tạo một ChatItem mới để chứa thông tin của một item
                ChatListItem chatListItem = new ChatListItem();

                // Lấy giá trị của cột hoặc thuộc tính chứa thông tin của người chat bằng cách sử dụng reflection
                object avatar = item.GetType().GetProperty("StrAvartar").GetValue(item);
                if (avatar != null)
                {
                    // Gán giá trị đó cho thuộc tính Avatar của ChatItem
                    chatListItem.Avatar = avatar as Image;
                }

                object name = item.GetType().GetProperty("StrNameStaff").GetValue(item);
                if (name != null)
                {
                    // Gán giá trị đó cho thuộc tính Name của ChatItem
                    chatListItem.UserName = name.ToString();
                }

                object message = item.GetType().GetProperty("StrContent").GetValue(item);
                if (message != null)
                {
                    // Gán giá trị đó cho thuộc tính Message của ChatItem
                    chatListItem.Message = message.ToString();
                }

                object time = item.GetType().GetProperty("TimeSend").GetValue(item);
                if (time != null)
                {
                    // Gán giá trị đó cho thuộc tính Time của ChatItem
                    chatListItem.Time = (DateTime)time;
                }
                chatListItem.Tag = item;
                chatListItem.Height = 50;
                chatListItem.Width = flpChatList.Width - 10 - scrWidth;
                chatListItem.Margin = new Padding(5);

                // Thêm ChatItem vào panel chính
                flpChatList.Controls.Add(chatListItem);

                // Thêm sự kiện Click cho ChatItem để thông báo khi người dùng nhấn vào nó
                chatListItem.Click += (sender, e) =>
                {
                    object clickedChatItem = (sender as ChatListItem).Tag;
                    // Nếu có sự kiện ItemClicked thì gọi nó và truyền vào đối tượng dữ liệu tương ứng với ChatItem
                    if (ItemClicked != null)
                    {
                        ItemClicked(clickedChatItem, EventArgs.Empty);
                    }
                };
            }
        }
    }
}
