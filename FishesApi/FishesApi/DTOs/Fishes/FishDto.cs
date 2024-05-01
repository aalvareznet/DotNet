﻿namespace FishesApi.DTOs.Fishes
{
    public class FishDto
    {
        public int FishId { get; set; }
        public string FishName { get; set; }
        public string FishDescription { get; set; }
        public int FishWeight { get; set; }
        public int FishLength { get; set; }
        public string FishColor { get; set; }
        public string PlaceOfCapture { get; set; }
        public int FishCategoryId { get; set; }

    }
}
