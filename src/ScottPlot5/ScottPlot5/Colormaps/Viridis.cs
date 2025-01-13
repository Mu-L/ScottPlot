﻿/* Viridis is a colormap by Nathaniel J. Smith, Stefan van der Walt, and Eric Firing
 * https://bids.github.io/colormap/
 * https://github.com/BIDS/colormap/blob/master/colormaps.py
 * 
 * This colormap is provided under the CC0 license / public domain dedication
 * http://creativecommons.org/publicdomain/zero/1.0/
 */

namespace ScottPlot.Colormaps;

public class Viridis : IColormap
{
    public string Name => "Viridis";
    private readonly CustomPalette Colormap;
    public Color GetColor(double position) => Colormap.GetColor(position);

    public Viridis()
    {
        uint[] rgbColors =
        [
            04456788, 04457045, 04457303, 04523352, 04523610, 04524123, 04589916, 04590430,
            04590687, 04591201, 04656994, 04657507, 04657765, 04658278, 04658535, 04658793,
            04659306, 04725099, 04725356, 04725870, 04726127, 04726384, 04726897, 04727154,
            04727411, 04727668, 04662645, 04662902, 04663159, 04663416, 04663929, 04664186,
            04664443, 04599164, 04599676, 04599933, 04600190, 04534911, 04535423, 04535680,
            04535937, 04470657, 04471170, 04405891, 04406147, 04406404, 04341124, 04341381,
            04341893, 04276614, 04276870, 04211591, 04211847, 04146567, 04147080, 04081800,
            04082057, 04016777, 04017033, 04017289, 03952010, 03952266, 03887242, 03887498,
            03822219, 03822475, 03757195, 03757451, 03692171, 03692428, 03627148, 03627404,
            03562124, 03562380, 03497100, 03497356, 03432077, 03432333, 03367053, 03367309,
            03302029, 03302285, 03237005, 03237261, 03237517, 03172237, 03172493, 03107213,
            03107469, 03042190, 03042446, 03042702, 02977422, 02977678, 02912398, 02912654,
            02912910, 02847630, 02847886, 02782606, 02782862, 02783118, 02717838, 02718094,
            02652814, 02652814, 02653070, 02587790, 02588046, 02588302, 02523022, 02523278,
            02523534, 02458254, 02458509, 02393229, 02393485, 02393741, 02328461, 02328717,
            02328973, 02263437, 02263693, 02263949, 02198669, 02198924, 02199180, 02133900,
            02134156, 02134412, 02069132, 02069387, 02069643, 02069899, 02070155, 02004874,
            02005130, 02005386, 02005386, 02005641, 02005897, 02006153, 02006408, 02006664,
            02006920, 02007175, 02072967, 02073222, 02073478, 02139269, 02139525, 02205317,
            02205572, 02271108, 02336899, 02337154, 02402946, 02468737, 02534529, 02600320,
            02666111, 02731903, 02797694, 02863485, 02929021, 03060348, 03126139, 03191930,
            03323258, 03389049, 03520376, 03586167, 03717494, 03783030, 03914357, 04045684,
            04111475, 04242802, 04374129, 04505200, 04570991, 04702318, 04833645, 04964972,
            05096043, 05227369, 05358696, 05490023, 05621350, 05752421, 05883748, 06015074,
            06211937, 06343008, 06474335, 06605661, 06802524, 06933595, 07064921, 07196248,
            07392854, 07524181, 07655508, 07852114, 07983441, 08180303, 08311374, 08508236,
            08639307, 08836169, 08967495, 09164102, 09295428, 09492035, 09623361, 09819967,
            09951294, 10147900, 10344762, 10475832, 10672695, 10869301, 11000627, 11197234,
            11394096, 11525166, 11722028, 11918635, 12049705, 12246567, 12443174, 12574500,
            12771106, 12967713, 13099039, 13295646, 13492253, 13623580, 13820187, 13951258,
            14148121, 14344728, 14475800, 14672664, 14803736, 15000344, 15197209, 15328281,
            15524890, 15656219, 15852828, 15983902, 16180767, 16311841, 16442914, 16639780,
        ];

        Color[] colors = rgbColors.Select(rgb => unchecked((uint)(0xFF << 24) | (uint)rgb)).Select(Color.FromARGB).ToArray();

        Colormap = new CustomPalette(colors);
    }
}
