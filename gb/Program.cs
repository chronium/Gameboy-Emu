using gb;
using LibreLancer;
using SDL3;

DllMap.Register(typeof(SDL).Assembly);

const int GB_SCREEN_WIDTH = 160;
const int GB_SCREEN_HEIGHT = 144;

const int SCALE_FACTOR = 8;

new Application().Init(GB_SCREEN_WIDTH * SCALE_FACTOR, GB_SCREEN_HEIGHT * SCALE_FACTOR)
    .OnQuit(app => Console.WriteLine("Quitting")).Run();