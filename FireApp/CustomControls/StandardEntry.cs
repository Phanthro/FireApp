using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireApp.CustomControls
{
    public class StandardEntry : Entry
    {
        public static BindableProperty CornerRadiusProperty =
            BindableProperty.Create( nameof( CornerRadius ), returnType: typeof( int ), declaringType: typeof( StandardEntry ), defaultValue: 0 );

        public static BindableProperty BorderThicknessProperty =
            BindableProperty.Create( nameof( BorderThickness ), returnType: typeof( int ), declaringType: typeof( StandardEntry ), defaultValue: 0 );

        public static BindableProperty PaddingProperty =
            BindableProperty.Create( nameof( Padding ), returnType: typeof( Thickness ), declaringType: typeof( StandardEntry ), defaultValue: new Thickness( 10 ));

        public static BindableProperty BorderColorProperty =
            BindableProperty.Create( nameof( BorderColor ), returnType: typeof( Color ), declaringType: typeof( StandardEntry ), defaultValue: Colors.Transparent );

        public static BindableProperty CustomHeightProperty =
            BindableProperty.Create( nameof( CustomHeight ), returnType: typeof( int ), declaringType: typeof( StandardEntry ), defaultValue: 0 );

        public int CornerRadius
        {
            get => (int)GetValue( CornerRadiusProperty );
            set => SetValue( CornerRadiusProperty, value );
        }

        public int BorderThickness
        {
            get => (int)GetValue( BorderThicknessProperty );
            set => SetValue( BorderThicknessProperty, value );
        }

        public Color BorderColor
        {
            get => (Color)GetValue( BorderColorProperty );
            set => SetValue( BorderColorProperty, value );
        }
        public Thickness Padding
        {
            get => (Thickness)GetValue( PaddingProperty );
            set => SetValue( PaddingProperty, value );
        }


        public int CustomHeight
        {
            get => (int)GetValue( CustomHeightProperty );
            set => SetValue( CustomHeightProperty, value );
        }

    }
}
