namespace RSL.CodeChallenge
{
    public static class Constants
    {
        public static int MaxDarwCountPerProduct = 20;

        public enum DataType
        {
            Json,
            FormData
        }

        /// <summary>
        /// Lotteries product enum from https://media.thelott.com/documentations/IData/DataTypes/LotteriesProduct.html
        /// </summary>
        public enum LotteriesProduct
        {
            None,
            TattsLotto,
            OzLotto,
            Powerball,
            Super66,
            Pools,
            MonWedLotto,
            LuckyLotteries2,
            LuckyLotteries5,
            LottoStrike,
            WedLotto,
            Keno,
            CoinToss,
            SetForLife,
            SetForLife744,
            MultiProduct,
            InstantScratchIts,
            TwoDollarCasket,
            BonusDraws,
            MultiProductSyndicate = 255
        }
    }
}
