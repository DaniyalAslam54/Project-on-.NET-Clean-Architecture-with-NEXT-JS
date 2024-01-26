﻿using HR.LeaveManagement.Application.Contracts.Persistence;
using MapsterMapper;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public GetLeaveTypesQueryHandler(IMapper mapper,ILeaveTypeRepository leaveTypeRepository)
    {
        this._mapper = mapper;
        this._leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, 
        CancellationToken cancellationToken)
    {
        var leaveTypes = await _leaveTypeRepository.GetAsync();

        var data = _mapper.Map<List<LeaveTypeDto>>(leaveTypes);

        return data;
    }
}
