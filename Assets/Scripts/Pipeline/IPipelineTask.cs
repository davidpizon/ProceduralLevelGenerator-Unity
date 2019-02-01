﻿namespace Assets.Scripts.Pipeline
{
	public interface IPipelineTask<TPayload> where TPayload : class
	{
		TPayload Payload { get; set; }

		void Process();
	}
}