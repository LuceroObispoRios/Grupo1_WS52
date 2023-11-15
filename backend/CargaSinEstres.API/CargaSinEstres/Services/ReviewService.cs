using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;
using CargaSinEstres.API.CargaSinEstres.Resources;
using CargaSinEstres.API.Security.Domain.Repositories;

namespace CargaSinEstres.API.CargaSinEstres.Services;

public class ReviewService : IReviewService
{
    private readonly IReviewRepository _reviewRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICompanyRepository _companyRepository;

    public ReviewService(IReviewRepository reviewRepository, IUnitOfWork unitOfWork, ICompanyRepository companyRepository)
    {
        _reviewRepository = reviewRepository;
        _unitOfWork = unitOfWork;
        _companyRepository = companyRepository;
        
    }

    public async Task<IEnumerable<Review>> ListAsync()
    {
        return await _reviewRepository.ListAsync();
    }
    
    public async Task<IEnumerable<Review>> FindByCompanyIdAsync(int companyId)
    {
        return await _reviewRepository.FindByCompanyIdAsync(companyId);
    }

    public async Task<ReviewResponse> SaveAsync(Review review)
    {
        // Validate if review comment is too short
        if (review.Comment.Length < 10)
            return new ReviewResponse("Comment must be at least 10 characters long.");
        
        try
        {
            await _reviewRepository.AddAsync(review);
            await _unitOfWork.CompleteAsync();
            return new ReviewResponse(review);
        }
        catch (Exception e)
        {
            return new ReviewResponse($"An error ocurred while saving the review: {e.Message}");
        }
    }
    
    
}