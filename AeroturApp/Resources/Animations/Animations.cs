//namespace AeroturApp.Resources.Animations
//{
//    class RippleAnimation : CommunityToolkit.Maui.Animations.BaseAnimation
//    {
//        Animation Ripple(VisualElement element)
//        {
//            var animation = new Animation();

//            animation.WithConcurrent((f) => {
//                element.Background = new RadialGradientBrush()
//                {
//                    Radius = f / 100
//                };
//                }, 0, 100, Easing.CubicInOut);
//            return animation;
//        }
//        public override Task Animate(VisualElement view)
//        {
//            view.Animate("Ripple", Ripple(view), 16, Length, repeat:()=>false);
//            return Task.CompletedTask;
//        }
//    }
//}
