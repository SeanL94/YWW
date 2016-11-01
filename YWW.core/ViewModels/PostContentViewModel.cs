using MvvmCross.Core.ViewModels;
using System;
using System.Windows.Input;
using YWW.core.Interfaces;
using YWW.core.Models;

namespace YWW.core.ViewModels
{
    public class PostContentViewModel : MvxViewModel
    {
        private readonly IPostDatabase postDatabase;
        public PostContentViewModel(IPostDatabase postDatabase)
        {
            this.postDatabase = postDatabase;
        }
        public void Init(Post post)
        {
            
        }
    }
}
