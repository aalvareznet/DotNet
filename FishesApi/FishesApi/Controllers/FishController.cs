using FishesApi.DTOs.Fishes;
using FishesApi.Models;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FishesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishController : ControllerBase
    {
        private FishContext _context;
        private IValidator<FishInsertDto> _validator;

        public FishController(FishContext context, IValidator<FishInsertDto> validator)
        {
            _context = context;
            _validator = validator;
        }
        [HttpGet]
        public async Task<IEnumerable<FishDto>> Get() =>
            await _context.Fishes.Select(f => new FishDto
            {
                FishId = f.FishId,
                FishName = f.FishName,
                FishDescription = f.FishDescription,
                FishWeight = f.FishWeight,
                FishLength = f.FishLength,
                FishColor = f.FishColor,
                PlaceOfCapture = f.PlaceOfCapture,
                FishCategoryId = f.FishCategoryId
            }).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<FishDto>> GetById(int id)
        {
            var fish = await _context.Fishes.FindAsync(id);

            if (fish == null)
            {
                return NotFound();
            }
            var fishDto = new FishDto
            {
                FishId = fish.FishId,
                FishName = fish.FishName,
                FishDescription = fish.FishDescription,
                FishWeight = fish.FishWeight,
                FishLength = fish.FishLength,
                FishColor = fish.FishColor,
                PlaceOfCapture = fish.PlaceOfCapture,
                FishCategoryId = fish.FishCategoryId
            };

            return Ok(fishDto);
        }
        [HttpPost]
        public async Task<ActionResult<FishDto>> Add(FishInsertDto fishInsertDto)
        {
            var validationResult = await _validator.ValidateAsync(fishInsertDto);
            if (!validationResult.IsValid) 
            {
                return BadRequest(validationResult.Errors);
            }
            var fish = new Fish
            {
                FishName = fishInsertDto.FishName,
                FishDescription = fishInsertDto.FishDescription,
                FishWeight = fishInsertDto.FishWeight,
                FishLength = fishInsertDto.FishLength,
                FishColor = fishInsertDto.FishColor,
                PlaceOfCapture = fishInsertDto.PlaceOfCapture,
                FishCategoryId = fishInsertDto.FishCategoryId
            };

            await _context.Fishes.AddAsync(fish);
            await _context.SaveChangesAsync();

            var FishDto = new FishDto
            {
                FishId = fish.FishId,
                FishName = fish.FishName,
                FishDescription = fish.FishDescription,
                FishWeight = fish.FishWeight,
                FishLength = fish.FishLength,
                FishColor = fish.FishColor,
                PlaceOfCapture = fish.PlaceOfCapture,
                FishCategoryId = fish.FishCategoryId
            };
            return CreatedAtAction(nameof(GetById), new { id = fish.FishId }, FishDto);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<FishDto>> Update(int id, FishUpdateDto fishUpdateDto) 
        {
            var fish = await _context.Fishes.FindAsync(id);

            if (fish == null)
            {
                return NotFound();
            }

            fish.FishName = fishUpdateDto.FishName;
            fish.FishDescription = fishUpdateDto.FishDescription;
            fish.FishWeight = fishUpdateDto.FishWeight;
            fish.FishLength = fishUpdateDto.FishLength;
            fish.FishColor = fishUpdateDto.FishColor;
            fish.PlaceOfCapture = fishUpdateDto.PlaceOfCapture;
            fish.FishCategoryId = fishUpdateDto.FishCategoryId;

            await _context.SaveChangesAsync();

            var FishDto = new FishDto
            {
                FishId = fish.FishId,
                FishName = fish.FishName,
                FishDescription = fish.FishDescription,
                FishWeight = fish.FishWeight,
                FishLength = fish.FishLength,
                FishColor = fish.FishColor,
                PlaceOfCapture = fish.PlaceOfCapture,
                FishCategoryId = fish.FishCategoryId
            };

            return Ok(FishDto);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var fish = await _context.Fishes.FindAsync(id);

            if (fish == null)
            {
                return NotFound();
            }

            _context.Fishes.Remove(fish);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
