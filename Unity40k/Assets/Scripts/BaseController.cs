using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{

    //https://i1.wp.com/objectivesecured.com.au/wp-content/uploads/2018/10/base-sizes.png?ssl=1
    public enum BaseSize {
        [Description("25mm")]
        TwentyFiveMM,
        [Description("32mm")]
        ThirtyTwoMM,
        [Description("40mm")]
        FourtyMM,
        [Description("50mm")]
        FiftyMM,
        [Description("60mm")]
        SixtyMM,
        [Description("80mm")]
        EightyMM,
        [Description("100mm")]
        OneHunderdMM,
        [Description("130mm")]
        OneHundredThirtyMM,
        [Description("160mm")]
        OneHundredSixtyMM,
        [Description("25x70mm")]
        TwentyFiveXSeventyMM,
        [Description("35x60mm")]
        ThirtyFiveXSixtyMM,
        [Description("46x70mm")]
        FourtySixXSeventyFiveMM,
        [Description("52x90mm")]
        FiftyTwoXNintyMM,
        [Description("70x105mm")]
        SeventyXOneHundredFiveMM,
        [Description("92x120mm")]
        NintyTwoXOneHundredTwentyMM,
        [Description("105x170mm")]
        OneHundredFiveXOneHundredOneHundredSeventyMM,

    }

    public BaseSize baseSize;
    public int baseWidth;
    public int baseHeight;

    // Start is called before the first frame update
    void Start()
    {
        switch (baseSize) {

            case BaseSize.TwentyFiveMM: {
                    baseWidth = 25;
                    baseHeight = 25;
                }
            case BaseSize.ThirtyTwoMM: {
                    baseWidth = 32;
                    baseHeight = 32;
                }
            case BaseSize.FourtyMM: {
                    baseWidth = 40;
                    baseHeight = 40;
                }
            case BaseSize.FiftyMM: {
                    baseWidth = 50;
                    baseHeight = 50;
                }
            case BaseSize.SixtyMM: {
                    baseWidth = 60;
                    baseHeight = 60;
                }
            case BaseSize.EightyMM: {
                    baseWidth = 80;
                    baseHeight = 80;
                }
            case BaseSize.OneHunderdMM: {
                    baseWidth = 100;
                    baseHeight = 100;
                }
            case BaseSize.OneHundredThirtyMM: {
                    baseWidth = 130;
                    baseHeight = 130;
                }
            case BaseSize.OneHundredSixtyMM: {
                    baseWidth = 160;
                    baseHeight = 160;
                }
            case BaseSize.TwentyFiveXSeventyMM: {
                    baseWidth = 70;
                    baseHeight = 25;
                }
            case BaseSize.ThirtyFiveXSixtyMM: {
                    baseWidth = 60;
                    baseHeight = 35;
                }
            case BaseSize.FourtySixXSeventyFiveMM: {
                    baseWidth = 70;
                    baseHeight = 46;
                }
            case BaseSize.FiftyTwoXNintyMM: {
                    baseWidth = 90;
                    baseHeight = 52;
                }
            case BaseSize.SeventyXOneHundredFiveMM: {
                    baseWidth = 105;
                    baseHeight = 70;
                }
            case BaseSize.NintyTwoXOneHundredTwentyMM: {
                    baseWidth = 120;
                    baseHeight = 92;
                }
            case BaseSize.OneHundredFiveXOneHundredOneHundredSeventyMM: {
                    baseWidth = 170;
                    baseHeight = 105;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setBaseSize() {

        GameObject unitBase = this.gameObject;

    }

}
