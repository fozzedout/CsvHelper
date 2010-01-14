﻿#region License
// Copyright 2009-2010 Josh Close
// This file is a part of CsvHelper and is licensed under the MS-PL
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CsvHelper
{
	/// <summary>
	/// Defines methods used to read parsed data
	/// from a CSV file.
	/// </summary>
	public interface ICsvReader : IDisposable
	{
		/// <summary>
		/// Gets the field headers.
		/// </summary>
		string[] FieldHeaders { get; }

		/// <summary>
		/// A <see cref="bool" /> value indicating if the CSV file has a header record.
		/// </summary>
		bool HasHeaderRecord { get; set; }

		/// <summary>
		/// Advances the reader to the next record.
		/// </summary>
		/// <returns>True if there are more records, otherwise false.</returns>
		bool Read();

		/// <summary>
		/// Gets the raw field at index.
		/// </summary>
		/// <param name="index">The index of the field.</param>
		/// <returns>The raw string field.</returns>
		string this[int index] { get; }

		/// <summary>
		/// Gets the raw string field at name.
		/// </summary>
		/// <param name="name">The named index of the field.</param>
		/// <returns>The raw string field.</returns>
		string this[string name] { get; }

		/// <summary>
		/// Gets the raw field at index.
		/// </summary>
		/// <param name="index">The index of the field.</param>
		/// <returns>The raw string field.</returns>
		string GetField( int index );

		/// <summary>
		/// Gets the raw field at name.
		/// </summary>
		/// <param name="name">The named index of the field.</param>
		/// <returns>The raw string field.</returns>
		string GetField( string name );

		/// <summary>
		/// Gets the field converted to type T at index.
		/// </summary>
		/// <typeparam name="T">The type of the field.</typeparam>
		/// <param name="index">The index of the field.</param>
		/// <returns>The field converted to type T.</returns>
		T GetField<T>( int index );

		/// <summary>
		/// Gets the field converted to type T at name.
		/// </summary>
		/// <typeparam name="T">The type of the field.</typeparam>
		/// <param name="name">The named index of the field.</param>
		/// <returns>The field converted to type T.</returns>
		T GetField<T>( string name );

		/// <summary>
		/// Gets the field converted to type T at index using
		/// the given <see cref="TypeConverter" />.
		/// </summary>
		/// <typeparam name="T">The type of the field.</typeparam>
		/// <param name="index">The index of the field.</param>
		/// <param name="converter">The converter used to convert the field to type T.</param>
		/// <returns>The field converted to type T.</returns>
		T GetField<T>( int index, TypeConverter converter );

		/// <summary>
		/// Gets the field converted to type T at name using
		/// the given <see cref="TypeConverter" />.
		/// </summary>
		/// <typeparam name="T">The type of the field.</typeparam>
		/// <param name="name">The named index of the field.</param>
		/// <param name="converter">The converter used to convert the field to type T.</param>
		/// <returns>The field converted to type T.</returns>
		T GetField<T>( string name, TypeConverter converter );

		/// <summary>
		/// Gets the record converted into type T.
		/// </summary>
		/// <typeparam name="T">The type of the record.</typeparam>
		/// <returns>The record converted to type T.</returns>
		T GetRecord<T>();

		/// <summary>
		/// Gets all the records in the CSV file and
		/// converts each to type T. The Read method
		/// should not be used when using this.
		/// </summary>
		/// <typeparam name="T">The type of the record.</typeparam>
		/// <returns>An <see cref="IList{T}" /> of records.</returns>
		IList<T> GetRecords<T>();
	}
}
