using AppBlog.org.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppBlog.org
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Post> lastPosts;

        public MainPage()
        {
            this.InitializeComponent();
            AddPosts();
        }
        public void AddPosts()
        {
            
            lastPosts = new List<Post>();

            Post post = new Post();
            post.Id = 12;
            post.Title = "Ok second title";
            post.Description = "Heyy are you still reading?";
            lastPosts.Add(post);

            Post post2 = new Post();
            post2.Id = 20;
            post2.Title = "Lorem Ipsum";
            post2.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi lacinia augue in sapien lobortis, eu dictum est dignissim. Sed vestibulum rutrum tellus. Nunc metus ligula, elementum eget lacus id, venenatis varius lorem. Ut tempus pulvinar tempor. Curabitur purus nibh, suscipit ac ligula eu, sagittis commodo tortor. Mauris placerat ex vel mauris cursus interdum. Vivamus id euismod nisi. Proin lacinia pulvinar nisl, et interdum lacus aliquet nec. Pellentesque urna dui, varius ac maximus molestie, fermentum a lectus. Aenean at metus varius, maximus lectus sit amet, volutpat ligula. ";
            lastPosts.Add(post2);

            Post post3 = new Post();
            post3.Id = 3;
            post3.Title = "What Are Articles?";
            post3.Description = "The indefinite article takes two forms. It’s the word a when it precedes a word that begins with a consonant. It’s the word an when it precedes a word that begins with a vowel. The indefinite article indicates that a noun refers to a general idea rather than a particular thing.";
            lastPosts.Add(post3);

            LastPostsListView.Height = Window.Current.Bounds.Height;
            LastPostsListView.Width = Window.Current.Bounds.Width;
            LastPostsListView.ItemsSource = lastPosts;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if(button != null)
            {
                Post selectedPost = new Post();
                foreach (var item in lastPosts)
                {
                    if (item.Id == Convert.ToInt32(button.CommandParameter))
                        selectedPost = item;
                }

                Frame.Navigate(typeof(ReadMore), selectedPost);
            }
        }
    }
}
