using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;

namespace Tracker.Web.Application
{
    public class ValidationBehavior<TRequest, TResponce>
        : IPipelineBehavior<TRequest, TResponce> where TRequest : IRequest<TResponce>
    {
        private readonly IEnumerable<IValidator<TRequest>> validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            this.validators = validators;
        }

        public Task<TResponce> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponce> next)
        {
            var context = new ValidationContext(request);

            var failures = validators.Select(x => x.Validate(context))
                                     .SelectMany(x => x.Errors)
                                     .Where(x => x != null)
                                     .ToArray();

            if (failures.Any())
            {
                throw new ValidationException(failures);
            }

            return next();
        }
    }
}
