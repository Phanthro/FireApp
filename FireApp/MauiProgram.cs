using CommunityToolkit.Maui;
using FireApp.CustomControls;
using FireApp.Platforms;
using Microsoft.Extensions.Logging;

namespace FireApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts( fonts =>
                {
                    fonts.AddFont( "OpenSans-Regular.ttf", "OpenSansRegular" );
                    fonts.AddFont( "OpenSans-Semibold.ttf", "OpenSansSemibold" );
                    fonts.AddFont( "Inter-Regular.ttf", "InterRegular" );
                    fonts.AddFont( "Inter-SemiBold.ttf", "InterSemiBold" );
                    fonts.AddFont( "Inter-Bold.ttf", "InterBold" );
                } )
                .UseMauiCommunityToolkit();
            Microsoft.Maui.Handlers.ElementHandler.ElementMapper.AppendToMapping( "Classic", ( handler, view ) =>
            {
                if (view is StandardEntry)
                {
                    EntryMapper.Map( handler, view );
                }
            } );

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
