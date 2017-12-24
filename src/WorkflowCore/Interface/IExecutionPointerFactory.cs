﻿using WorkflowCore.Models;

namespace WorkflowCore.Interface
{
    public interface IExecutionPointerFactory
    {
        ExecutionPointer BuildStartingPointer(WorkflowDefinition def);
        ExecutionPointer BuildCompensationPointer(WorkflowDefinition def, ExecutionPointer pointer, ExecutionPointer exceptionPointer, int compensationStepId);
        ExecutionPointer BuildNextPointer(WorkflowDefinition def, ExecutionPointer pointer, StepOutcome outcomeTarget);
        ExecutionPointer BuildChildPointer(WorkflowDefinition def, ExecutionPointer pointer, int childDefinitionId, object branch);
    }
}