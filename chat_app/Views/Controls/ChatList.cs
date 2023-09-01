using chat_app.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_app.Views.Controls
{
    [ComplexBindingProperties("DataSource", "DataMember")]
    public partial class ChatList : UserControl
    {
        private BindingSource bindingSource;
        private int itemWidth;
        private int itemHeight;
        private Color _itemBackColor;
        private Color _itemHoverColor;
        private ChatListItem _lastClickItem;


        // Khai báo một sự kiện để thông báo khi người dùng nhấn vào một item trong user control
        public event EventHandler ItemClicked;
        public ChatList()
        {
            InitializeComponent();
            AssignEvent();
            
        }

        private void AssignEvent()
        {
            this.Load += ChatList_Load;
            pnChatList.SizeChanged += ChatList_SizeChanged;
        }

        private void ChatList_Load(object sender, EventArgs e)
        {
            itemWidth = this.Width;
        }

        private void ChatList_SizeChanged(object sender, EventArgs e)
        {
            if(itemWidth != Width)
            {
                itemWidth = this.Width;
                ChangeItemSize();
            }
        }

        private void ChangeItemSize()
        {

            int btnSize; // Lưu kích thước gốc của pnMenu
            bool isScrollBarVisible = pnChatList.VerticalScroll.Visible;

            if (isScrollBarVisible)
            {
                btnSize = itemWidth - SystemInformation.VerticalScrollBarWidth -10;
            }
            else
            {
                btnSize = itemWidth - 10;
            }
            foreach (Control control in pnChatList.Controls)
            {
                if (control is ChatListItem chatItem)
                {
                    chatItem.Width = btnSize;
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

        public int ItemHeight { get => itemHeight; set => itemHeight = value; }
        public Color ItemBackColor { get => _itemBackColor; set => _itemBackColor = value; }
        public Color ItemHoverColor { get => _itemHoverColor; set => _itemHoverColor = value; }

        private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshChatList();
        }


        private async Task<Image> GetImageFromFTP(string url)
        {
            Image image = null;
            Task<Image> t1 = new Task<Image>(
                () =>
                {
                    try
                    {
                        Image im = null;
                        if (string.IsNullOrEmpty(url))
                        {
                            byte[] imageData;
                            using (WebClient client = new WebClient())
                            {
                                client.Credentials = new NetworkCredential("username", "password");
                                imageData = client.DownloadData(url);
                            }

                            // Convert the byte array to an Image
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                im = Image.FromStream(ms);
                            }
                        }
                        return im;

                    }
                    catch { return null; }
                });
            t1.Start();
            image = await t1;
            return image;
        }

        // Phương thức để hiển thị dữ liệu lên các item trong user control
        private async void RefreshChatList()
        {
            // Xóa tất cả các item cũ trong panel
            pnChatList.Controls.Clear();

            // Nếu không có dữ liệu hoặc tên cột hoặc thuộc tính thì thoát khỏi phương thức
            if (bindingSource == null || bindingSource.Count < 1) return;

            // Duyệt qua từng đối tượng trong danh sách dữ liệu
            var chatList = bindingSource.DataSource as IEnumerable<ChatListModel>;
            int y = 0;
            foreach (var item in chatList)
            {
                // Tạo một ChatItem mới để chứa thông tin của một item
                ChatListItem chatListItem = new ChatListItem();

                // Lấy giá trị của cột hoặc thuộc tính chứa thông tin của người chat bằng cách sử dụng reflection
                if (item.PartnerAvartar != null)
                {
                    // Gán giá trị đó cho thuộc tính Avatar của ChatItem
                    chatListItem.Image = await GetImageFromFTP(item.PartnerAvartar);
                }

                chatListItem.FillColor = Color.FromArgb(240,240,240);
                chatListItem.Text = item.PartnerName;
                chatListItem.LastMessage = item.LastMessage;
                chatListItem.LastChatTime = item.TimeSend;
                chatListItem.Image = Properties.Resources.avatar11;
                chatListItem.Tag = item;

                chatListItem.Height = ItemHeight;
                chatListItem.Width = itemWidth -10;
                chatListItem.Location = new Point(5, y);


                // Thêm ChatItem vào panel chính
                pnChatList.Controls.Add(chatListItem);
                y += itemHeight;

                // Thêm sự kiện Click cho ChatItem để thông báo khi người dùng nhấn vào nó
                chatListItem.Click += (sender, e) =>
                {
                    if (_lastClickItem != null) { _lastClickItem.Checked = false; }
                    var clickItem = sender as ChatListItem;
                    clickItem.Checked = true;
                    _lastClickItem = clickItem;

                    object clickedChatItem = clickItem.Tag;
                    // Nếu có sự kiện ItemClicked thì gọi nó và truyền vào đối tượng dữ liệu tương ứng với ChatItem
                    ItemClicked?.Invoke(clickedChatItem, e);
                };
            }
            ChangeItemSize();
        }
    }
}
