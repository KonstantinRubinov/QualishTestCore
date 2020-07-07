﻿using System.Collections.Generic;

namespace QualishTestBLL
{
	public class AllDataManager : IAllDataRepository
	{
		public AllData GetAllData()
		{
			List<AppointmentImportance> appointmentImportances = new AppointmentImportanceManager().GetAllAppointmentImportances();
			List<Appointment> appointments = new AppointmentManager().GetAllAppointments();
			List<AppointmentType> appointmentTypes = new AppointmentTypeManager().GetAllAppointmentTypes();

			AllData allData = new AllData(appointments, appointmentImportances, appointmentTypes);
			return allData;
		}
	}
}
